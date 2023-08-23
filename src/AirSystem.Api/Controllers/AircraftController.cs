using AirSystem.Database.Contexts;
using AirSystem.Models.Dtos;
using AirSystem.Models.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AirSystem.Api.Controllers;

/// <summary>
/// Api for aircraft
/// </summary>
[ApiController]
[Route("[controller]")]
public class AircraftController : ControllerBase
{
    private readonly ILogger<AircraftController> _logger;
    private readonly AirSystemContext _context;
    private readonly IMapper _mapper;

    public AircraftController(
        ILogger<AircraftController> logger,
        AirSystemContext context,
        IMapper mapper)
    {
        _logger = logger;
        _context = context;
        _mapper = mapper;
    }

    [HttpGet(Name = "get")]
    public Result<AircraftDto> Get()
    {
        var list = _context.Aircrafts
            .Include(x => x.Manufacturer)
            .ToArray();

        var dtos =  _mapper.Map<IEnumerable<AircraftDto>>(list).ToList();

        var res = new Result<AircraftDto>
        {
            Count = dtos.Count(),
            Limit = Int32.MaxValue,
            Page = 0,
            List = dtos
        };

        return res;
    }
    
    [HttpGet("{id:guid}")]
    public async Task<ActionResult<Aircraft>> GetAircraft(Guid id)
    {
        var aircraft = await _context.Aircrafts.FindAsync(id);

        if (aircraft == null)
        {
            return NotFound();
        }

        return aircraft;
    }
    
    [HttpPost]
    public async Task<ActionResult<Aircraft>> Post(Aircraft aircraft)
    {
        _context.Aircrafts.Add(aircraft);
        await _context.SaveChangesAsync();

        return aircraft;
    }

    [HttpPut]
    public async Task<IActionResult> Put(Guid id, [FromBody]Aircraft aircraft)
    {
        if (id != aircraft.Id)
        {
            return BadRequest();
        }

        await _context.SaveChangesAsync();

        return Ok();
    }
}

/// <summary>
/// TODO for future pagination
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public class Result<TEntity>
{
    public List<TEntity> List { get; set; }
    public int Count { get; set; }
    public int Limit { get; set; }
    public int Page { get; set; }
}