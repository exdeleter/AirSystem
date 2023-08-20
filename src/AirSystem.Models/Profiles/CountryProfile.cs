using AirSystem.Models.Dtos;
using AirSystem.Models.Entities;
using AutoMapper;

namespace AirSystem.Models.Profiles;

/// <summary>
/// <see cref="Country"/> profile
/// </summary>
public class CountryProfile : Profile
{
    public CountryProfile()
    {
        CreateMap<Country, CountryDto>().ReverseMap();
    }
}