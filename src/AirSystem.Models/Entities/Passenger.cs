using AirSystem.Models.Entities.Base;

namespace AirSystem.Models.Entities;

/// <summary>
/// Passenger
/// </summary>
public class Passenger : BaseEntity
{
    /// <summary>
    /// Flight
    /// </summary>
    public Flight Flight { get; set; }

    /// <summary>
    /// Flight' id
    /// </summary>
    public Guid FlightId { get; set; }
    
    /// <summary>
    /// FirstName
    /// </summary>
    public string FirstName { get; set; }
    
    /// <summary>
    /// Lastname
    /// </summary>
    public string LastName { get; set; }
    
    /// <summary>
    /// SeatNumber
    /// </summary>
    public string SeatNumber { get; set; }
}