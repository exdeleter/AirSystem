using AirSystem.Models.Dtos;
using AirSystem.Models.Entities;
using AutoMapper;

namespace AirSystem.Models.Profiles;

/// <summary>
/// <see cref="Airline"/> profile
/// </summary>
public class AirlineProfile : Profile
{
    public AirlineProfile()
    {
        CreateMap<Airline, AirlineDto>();
        
        CreateMap<AirlineDto, Airline>()
            .ForMember(x => x.City, 
                exp => exp.Ignore())
            .ForMember(x => x.CityId,
                exp => exp
                    .MapFrom(t => t.CityId));
    }
}