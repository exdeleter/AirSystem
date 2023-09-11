using AirSystem.Models.Entities.Base;

namespace AirSystem.Models.Entities;

public class Passenger : BaseEntity
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
    public string FirstName { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string LastName { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public string SeatNumber { get; set; }
}