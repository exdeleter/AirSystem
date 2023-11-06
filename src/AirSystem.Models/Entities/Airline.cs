using AirSystem.Abstractions.Interfaces;
using AirSystem.Models.Entities.Base;

namespace AirSystem.Models.Entities;

/// <summary>
/// Airline
/// </summary>
public class Airline : BaseEntity, IHaveAviaCode
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
    public City City { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid CityId { get; set; }

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
}