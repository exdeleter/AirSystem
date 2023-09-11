using AirSystem.Abstractions;
using AirSystem.Database.Contexts;
using AirSystem.Models.Dtos;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AirSystem.Api.Controllers;

/// <summary>
/// Api for airline
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class CityController : ControllerBase
{
    private readonly ILogger<CityController> _logger;
    private readonly AirSystemContext _context;
    private readonly IMapper _mapper;
    private readonly IBaseService<CityDto> _service;

    /// <summary>
    /// Constructor
    /// </summary>
    public CityController(
        ILogger<CityController> logger,
        AirSystemContext context,
        IMapper mapper,
        IBaseService<CityDto> service)
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
    public async Task<ActionResult<List<CityDto>>> List()
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
    public async Task<ActionResult<CityDto>> Get(Guid id)
    {
        var entity = await _service.Get(id);

        return new ActionResult<CityDto>(entity);
    }

    /// <summary>
    /// Add entity
    /// </summary>
    /// <param name="dto">Dto's entity</param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ActionResult<CityDto>> Post(CityDto dto)
    {
        var ent = await _service.Post(dto);

        return new ActionResult<CityDto>(ent);
    }

    /// <summary>
    /// Update entity
    /// </summary>
    /// <param name="dto">Dto's entity</param>
    /// <returns></returns>
    [HttpPut]
    public async Task<ActionResult<CityDto>> Put(CityDto dto)
    {
        var ent = await _service.Put(dto);

        if (ent == null)
        {
            return NotFound();
        }

        return new ActionResult<CityDto>(dto);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    [HttpDelete]
    public async Task<IResult> Delete(Guid id)
    {
        await _service.Delete(id);

        return Results.Ok(id);
    }
}
