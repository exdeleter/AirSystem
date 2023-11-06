using AirSystem.Models.Entities.Base;

namespace AirSystem.Models.Entities;

/// <summary>
/// Route
/// </summary>
public class Route : BaseEntity
{
    /// <summary>
    /// 
    /// </summary>
    public Guid DepartureAirportId {get; set;}

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public Airport DepartureAirport { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid ArrivalAirportId  {get; set;}

    /// <summary>
    /// 
    /// </summary>
    public Airport ArrivalAirport { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public double Distance { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public TimeSpan Duration { get; set; }
}