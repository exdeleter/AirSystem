using AirSystem.Models.Dtos.Base;

namespace AirSystem.Models.Dtos;

/// <summary>
/// Dto for aircraft
/// </summary>
public class AircraftDto : BaseDto
{
    /// <summary>
    /// Model
    /// </summary>
    public required string Model { get; set; }
    
    /// <summary>
    /// Manufacturer name
    /// </summary>
    public required string ManufacturerName { get; set; }
}