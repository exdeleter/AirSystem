using AirSystem.Models.Entities.Base;

namespace AirSystem.Models.Entities;

public class Crew : BaseEntity
{
    /// <summary>
    /// 
    /// </summary>
    public Flight Flight { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid FlightId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    //todo may be todo later separate class
    public string Pilot { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string CoPilot { get; set; }
}