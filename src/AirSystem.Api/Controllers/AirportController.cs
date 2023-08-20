using System.Globalization;
using AirSystem.Database.Contexts;
using AirSystem.Models.Dtos;
using AirSystem.Models.Entities;
using AutoMapper;
using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AirSystem.Api.Controllers;

/// <inheritdoc />
[ApiController]
[Route("api/[controller]")]
public class AirportController : ControllerBase
{
    private readonly ILogger<AirportController> _logger;
    private readonly AirSystemContext _context;
    private readonly IMapper _mapper;
    private readonly CsvConfiguration _csvConfiguration = new CsvConfiguration(CultureInfo.InvariantCulture){ Delimiter = ","};

    public AirportController(ILogger<AirportController> logger, AirSystemContext context, IMapper mapper)
    {
        _logger = logger;
        _context = context;
        _mapper = mapper;
    }

    [HttpPost("upload")]
    public async Task<ActionResult> UploadFile(IFormFile file)
    {
        await using var stream = file.OpenReadStream();
        using var streamReader = new StreamReader(stream);
        using var csvReader = new CsvReader(streamReader, _csvConfiguration);

        var notnull = csvReader
            .GetRecords<AirportImport>()
            .Where(x => x.IATACode != string.Empty && x.ICAOCode != string.Empty)
            .ToList();

        var airports = new List<Airport>();

        foreach (var airport in notnull)
        {
            var city = await _context.Cities.FirstOrDefaultAsync(x => x.Name == airport.Municipality);
            var country = await _context.Countries.FirstOrDefaultAsync(x => x.Name == airport.CountryName);

            if (city == null)
            {
                if (country == null)
                {
                    country = new Country()
                    {
                        Name = airport.CountryName,
                        Id = new Guid()
                    };
                    _context.Add(country);
                }

                city = new City()
                {
                    Id = new Guid(),
                    Name = airport.Municipality,
                    Country = country
                };

                _context.Add(city);
            }

            //TODO later added check for exist
            var entity = new Airport()
            {
                City = city,
                IATACode = airport.IATACode,
                IKAOCode = airport.ICAOCode,
                Id = new Guid(),
                Latitude = airport.Latitude,
                Longitude = airport.Longitude,
                Name = airport.Name,
                WebCite = airport.Website
            };

            airports.Add(entity);
        }

        await _context.AddRangeAsync(airports);
        await _context.SaveChangesAsync();

        stream.Close();
        streamReader.Close();
        return Ok(notnull);
    }
}
