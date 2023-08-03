using AirSystem.Models.Dtos.Base;

namespace AirSystem.Models.Dtos;

public class AircraftDto : BaseDto
{
    public string Model { get; set; }
    public string ManufacturerName { get; set; }
}