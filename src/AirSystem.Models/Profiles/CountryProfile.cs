using AirSystem.Models.Dtos;
using AirSystem.Models.Entities;
using AutoMapper;

namespace AirSystem.Models.Profiles;

/// <summary>
/// <see cref="Country"/> profile
/// </summary>
public class CountryProfile : Profile
{
    /// <summary>
    /// <inheritdoc cref="CountryProfile"/>
    /// </summary>
    public CountryProfile()
    {
        CreateMap<Country, CountryDto>().ReverseMap();
    }
}