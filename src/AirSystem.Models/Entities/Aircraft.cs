using AirSystem.Models.Entities.Base;

namespace AirSystem.Models.Entities;

/// <summary>
/// Aircraft
/// </summary>
public class Aircraft : BaseEntity
{ 
    /// <summary>
    /// Code of registration
    /// </summary>
    public string RegistrationCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid ManufacturerId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Manufacturer Manufacturer { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Count of seats
    /// </summary>
    public int Capacity {get;set;}

    /// <summary>
    /// 
    /// </summary>
    public int ReleaseYear { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int? MaxSpeed { get; set; }
}