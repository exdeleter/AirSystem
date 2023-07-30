using AirSystem.Models.Entities.Base;

namespace AirSystem.Models.Entities;

public class Flight : BaseEntity
{
    /// <summary>
    /// 
    /// </summary>
    public Guid AircraftId { get; set; }
    
    ///<summary>
    ///
    ///</summary>
    public Aircraft Aircraft { get; set; }
    
    ///<summary>
    ///
    ///</summary>
    public Guid AirlineId { get; set; }
    
    ///<summary>
    ///
    ///</summary>
    public Airline Airline { get; set; }
    
    ///<summary>
    ///
    ///</summary>
    public Guid RouteId { get; set; }
    
    ///<summary>
    ///
    ///</summary>
    public Route Route { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Number { get; set; }
    
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