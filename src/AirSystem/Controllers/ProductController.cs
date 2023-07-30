using AirSystem.Database.Contexts;
using AirSystem.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AirSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class AircraftController : ControllerBase
{
    private readonly ILogger<AircraftController> _logger;
    private readonly AirSystemContext _context;
    // private readonly IMapper _mapper;

    public AircraftController(ILogger<AircraftController> logger, AirSystemContext context)//, IMapper mapper)
    {
        _logger = logger;
        _context = context;
        // _mapper = mapper;
    }

    [HttpGet(Name = "get")]
    public IEnumerable<Aircraft> Get()
    {
        return _context.Aircrafts.ToList();
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

//     [HttpGet("{companyName}")]
//     public IEnumerable<ProductListDto> List(string companyName)
//     {
//         if (companyName is null)
//         {
//
//             return _mapper.Map<IEnumerable<ProductListDto>>(_context.Products.ToList());
//         }
//
//         var products =  _context.Products
//             .Include(x => x.Company)
//             .Where(x => x.Company.Name == companyName).ToList();
// //todo read about projectTo
//         return _mapper.Map<IEnumerable<ProductListDto>>(products);
//     }
}