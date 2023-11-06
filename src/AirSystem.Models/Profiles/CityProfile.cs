using AirSystem.Models.Dtos;
using AirSystem.Models.Entities;
using AutoMapper;

namespace AirSystem.Models.Profiles;

/// <summary>
/// <see cref="City"/> profile
/// </summary>
public class CityProfile : Profile
{
    /// <summary>
    /// <inheritdoc cref="CityProfile"/>
    /// </summary>
    public CityProfile()
    {
        CreateMap<City, CityDto>().ReverseMap();
    }
}