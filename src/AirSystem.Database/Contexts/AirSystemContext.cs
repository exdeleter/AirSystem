using AirSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AirSystem.Database.Contexts;

/// <summary>
/// Контекст VapeStore
/// </summary>
public class AirSystemContext : DbContext
{
    /// <inheritdoc />
    public AirSystemContext(DbContextOptions<AirSystemContext> options)
        : base(options)
    {
    }
    
    public DbSet<Aircraft> Aircrafts { get; set; }
    
    public DbSet<Airline> Airlines { get; set; }
    
    public DbSet<Airport> Airports { get; set; }
    
    public DbSet<Country> Countries { get; set; }
    
    public DbSet<Flight> Flights { get; set; }
    
    public DbSet<Manufacturer> Manufacturers { get; set; }
    
    public DbSet<Route> Routes { get; set; }

    public AirSystemContext() => Database.EnsureCreated();

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlite("Data Source=helloapp.db");
    // }
}