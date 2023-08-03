using AirSystem.Models.Dtos;
using AirSystem.Models.Entities;
using AutoMapper;

namespace AirSystem.Models.Profiles;

public class AircraftProfile : Profile
{
    public AircraftProfile()
    {
        CreateMap<Aircraft, AircraftDto>()
            .ForMember(
                x => x.ManufacturerName,
                w => w.MapFrom(e => e.Manufacturer.Name));
    }
}