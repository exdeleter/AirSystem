using AirSystem.Abstractions;
using AirSystem.Database.Contexts;
using AirSystem.Models.Dtos;
using AirSystem.Models.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace AirSystem.Api.Controllers;

/// <summary>
/// Api for airline
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class AirlineController : ControllerBase
{
    private readonly ILogger<AirlineController> _logger;
    private readonly AirSystemContext _context;
    private readonly IMapper _mapper;
    private readonly IBaseService<AirlineDto> _service;

    /// <summary>
    /// Constructor
    /// </summary>
    public AirlineController(
        ILogger<AirlineController> logger,
        AirSystemContext context,
        IMapper mapper,
        IBaseService<AirlineDto> service)
    {
        _logger = logger;
        _context = context;
        _mapper = mapper;
        _service = service;
    }

    /// <summary>
    /// Get list
    /// </summary>
    /// <returns></returns>
    [HttpGet("list")]
    public async Task<ActionResult<List<AirlineDto>>> List()
    {
        _logger.LogInformation("Method get for airline controller");

        var dtos = await _service.List();

        return dtos;
    }

    /// <summary>
    /// Get record with id
    /// </summary>
    /// <param name="id">Id</param>
    /// <returns>AirlineDto</returns>
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

    /// <summary>
    /// Add entity
    /// </summary>
    /// <param name="dto">Dto's entity</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ActionResult<AirlineDto>> Post(AirlineDto dto)
    {
        var entity = _mapper.Map<Airline>(dto);

         _context.Airlines.Add(entity);

        await _context.SaveChangesAsync();

        return new ActionResult<AirlineDto>(dto);
    }

    /// <summary>
    /// Update entity
    /// </summary>
    /// <param name="dto">Dto's entity</param>
    /// <returns></returns>
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
