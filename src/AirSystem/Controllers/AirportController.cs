using System.Globalization;
using AirSystem.Database.Contexts;
using AirSystem.Models.Dtos;
using AirSystem.Models.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CsvHelper;
using CsvHelper.Configuration;

namespace AirSystem.Controllers;

/// <inheritdoc />
[ApiController]
[Route("[controller]")]
public class AirportController : ControllerBase
{
    static string pathCsvFile = "Airports.csv";
    static string[] dangerousChar = { "ь", ".", "й", "ы"};
    private readonly ILogger<AirportController> _logger;
    private readonly AirSystemContext _context;
    private readonly IMapper _mapper;

    public AirportController(ILogger<AirportController> logger, AirSystemContext context, IMapper mapper)//, IMapper mapper)
    {
        _logger = logger;
        _context = context;
        _mapper = mapper;
    }

    [HttpGet(Name = "getAirport")]
    public IEnumerable<AirportImport> Get()
    {
        using (StreamReader streamReader = new StreamReader(pathCsvFile))
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture){ Delimiter = ","};
            using (CsvReader csvReader = new CsvReader(streamReader, config))
            {
                var test =  csvReader.GetRecords<AirportImport>().ToList();

                //TODO save to db
                //need to check do we have this record or not
                // also check the country and city
                // maybe set guid :) 
                return test;
            }
        }
    }
}
