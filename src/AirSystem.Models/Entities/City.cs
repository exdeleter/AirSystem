using AirSystem.Models.Entities.Base;

namespace AirSystem.Models.Entities;

/// <summary>
/// City of airport
/// </summary>
public class City : BaseEntity
{
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public Country Country { get; set; }

    /// <summary>
    /// Country id
    /// </summary>
    public Guid CountryId { get; set; }
}