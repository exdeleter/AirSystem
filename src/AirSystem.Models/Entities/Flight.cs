using AirSystem.Models.Entities.Base;

namespace AirSystem.Models.Entities;

/// <summary>
/// Flight
/// </summary>
public class Flight : BaseEntity
{
    /// <summary>
    /// 
    /// </summary>
    public Guid AircraftId { get; set; }
    
    ///<summary>
    ///
    ///</summary>
    public required Aircraft Aircraft { get; set; }
    
    ///<summary>
    ///
    ///</summary>
    public Guid AirlineId { get; set; }
    
    ///<summary>
    ///
    ///</summary>
    public required Airline Airline { get; set; }
    
    ///<summary>
    ///
    ///</summary>
    public Guid RouteId { get; set; }
    
    ///<summary>
    ///
    ///</summary>
    public required Route Route { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public required string Number { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public DateTime ScheduledDepartureTime { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public DateTime? FactDepartureTime { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public DateTime ScheduledArrivalTime { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public DateTime? FactArrivalTime { get; set; }
}