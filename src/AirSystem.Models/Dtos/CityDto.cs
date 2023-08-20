using AirSystem.Models.Dtos.Base;
using AirSystem.Models.Entities;

namespace AirSystem.Models.Dtos;

/// <summary>
/// <see cref="City"/> profile
/// </summary>
public class CityDto : BaseDto
{
    public string Name { get; set; }

    public CountryDto Country { get; set; }
}