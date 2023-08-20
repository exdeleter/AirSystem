using AirSystem.Database.Contexts;
using AirSystem.Models.Dtos;
using AirSystem.Models.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AirSystem.Api.Controllers;

/// <inheritdoc />
[ApiController]
[Route("api/[controller]")]
public class AirlineController : ControllerBase
{
    private readonly ILogger<AirlineController> _logger;
    private readonly AirSystemContext _context;
    private readonly IMapper _mapper;

    public AirlineController(
        ILogger<AirlineController> logger,
        AirSystemContext context,
        IMapper mapper)
    {
        _logger = logger;
        _context = context;
        _mapper = mapper;
    }

    [HttpGet("list")]
    public async Task<ActionResult<List<AirlineDto>>> List()
    {
        _logger.LogInformation("Method get for airline controller");

        var dtos = _context.Airlines
            .Include(x => x.City)
            .ThenInclude(x => x.Country);

        return await _mapper.ProjectTo<AirlineDto>(dtos).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AirlineDto>> Get(Guid id)
    {
        var entity = await _context.Airlines
            .FirstOrDefaultAsync(x => x.Id == id);

        if (entity is null)
        {
            return NotFound();
        }

        var dto = _mapper.Map<AirlineDto>(entity);

        await _context.SaveChangesAsync();

        return new ActionResult<AirlineDto>(dto);
    }

    [HttpPost(Name = "PostAirline")]
    public async Task<ActionResult<AirlineDto>> Post(AirlineDto dto)
    {
        var entity = _mapper.Map<Airline>(dto);

         _context.Airlines.Add(entity);

        await _context.SaveChangesAsync();

        return new ActionResult<AirlineDto>(dto);
    }

    [HttpPut]
    public async Task<ActionResult<AirlineDto>> Put(AirlineDto dto)
    {
        var ent = await _context.Airlines.AnyAsync(x => x.Id == dto.Id);

        if (!ent)
        {
            return NotFound();
        }

        var entity = _mapper.Map<Airline>(dto);

        _context.Airlines.Update(entity);

        await _context.SaveChangesAsync();

        return new ActionResult<AirlineDto>(dto);
    }
}
