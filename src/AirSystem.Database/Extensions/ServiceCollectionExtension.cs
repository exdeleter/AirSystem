using AirSystem.Database.Contexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AirSystem.Database.Extensions;

/// <summary>
/// Класс, расширяющий <see cref="WebApplication"/>
/// </summary>
public static partial class ServiceCollectionExtension
{
    /// <summary>
    /// Выполнение непроведенных миграций
    /// </summary>
    /// <param name="app"></param>
    public static async void ApplyMigrate(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<AirSystemContext>();
        await db.Database.MigrateAsync();
    }
}