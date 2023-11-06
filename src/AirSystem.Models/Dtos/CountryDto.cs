using AirSystem.Models.Dtos.Base;
using AirSystem.Models.Entities;

namespace AirSystem.Models.Dtos;

/// <summary>
/// <see cref="Country"/> profile
/// </summary>
public class CountryDto : BaseDto
{
    /// <summary>
    /// Name
    /// </summary>
    public string Name { get; set; }
}