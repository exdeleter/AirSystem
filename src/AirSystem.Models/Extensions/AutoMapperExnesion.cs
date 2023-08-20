using AirSystem.Models.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace AirSystem.Models.Extensions;

/// <summary>
/// Extension class
/// </summary>
public static class AutoMapperExnesion
{
    /// <summary>
    /// Add profiles
    /// </summary>
    /// <param name="services"></param>
    public static void ConfigureProfiles(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AircraftProfile));
        services.AddAutoMapper(typeof(AirlineProfile));
        services.AddAutoMapper(typeof(CityProfile));
        services.AddAutoMapper(typeof(CountryProfile));
    }
}