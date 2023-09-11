using AirSystem.Models.Dtos.Base;
using AirSystem.Models.Entities;

namespace AirSystem.Models.Dtos;

/// <summary>
/// Dto of <see cref="Airline"/>
/// </summary>
public class AirlineDto : BaseDto
{
    /// <summary>
    /// Airport short  name
    /// </summary>
    public string ShortName { get; set; }

    /// <summary>
    /// Airport full name
    /// </summary>
    public string FullName { get; set; }

    /// <inheritdoc />
    public string ICAOCode { get; set; }

    /// <inheritdoc />
    public string IATACode { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string? Website { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string CallSign { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string? LogoUrl { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid CityId { get; set; }
}