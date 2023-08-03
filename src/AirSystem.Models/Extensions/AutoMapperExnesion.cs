using AirSystem.Models.Profiles;
using Microsoft.Extensions.DependencyInjection;

namespace AirSystem.Models.Extensions;

public static class AutoMapperExnesion
{
    public static void ConfigureProfiles(this IServiceCollection services)
    {
        // другой код
        services.AddAutoMapper(typeof(AircraftProfile));
        // другой код
    }
}