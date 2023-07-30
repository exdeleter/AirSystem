using AirSystem.Models.Entities.Base;

namespace AirSystem.Models.Entities;

public class Airline : BaseEntity
{
    /// <summary>
    /// Airline name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid CountryId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Country Country { get; set; }
}