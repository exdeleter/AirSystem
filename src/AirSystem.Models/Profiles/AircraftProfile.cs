using AirSystem.Models.Dtos;
using AirSystem.Models.Entities;
using AutoMapper;

namespace AirSystem.Models.Profiles;

/// <summary>
/// <see cref="Aircraft"/> profile
/// </summary>
public class AircraftProfile : Profile
{
    /// <summary>
    /// <inheritdoc cref="AirlineProfile"/>
    /// </summary>
    public AircraftProfile()
    {
        CreateMap<Aircraft, AircraftDto>()
            .ForMember(
                x => x.ManufacturerName,
                w => w.MapFrom(e => e.Manufacturer.Name));
    }
}