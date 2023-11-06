using AirSystem.Models.Dtos.Base;
using AirSystem.Models.Entities;

namespace AirSystem.Models.Dtos;

/// <summary>
/// <see cref="City"/> profile
/// </summary>
public class CityDto : BaseDto
{
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public CountryDto Country { get; set; }
}