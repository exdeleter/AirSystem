using AirSystem.Models.Dtos;
using AirSystem.Models.Entities;
using AutoMapper;

namespace AirSystem.Models.Profiles;

/// <summary>
/// <see cref="City"/> profile
/// </summary>
public class CityProfile : Profile
{
    public CityProfile()
    {
        CreateMap<City, CityDto>().ReverseMap();
    }
}