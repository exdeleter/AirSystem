using AirSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirSystem.Database.Configurations;

/// <summary>
/// <see cref="Flight"/> configuration
/// </summary>
internal class FlightConfiguration : IEntityTypeConfiguration<Flight>
{
    public void Configure(EntityTypeBuilder<Flight> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.AircraftId)
            .HasComment("Aircraft Id")
            .HasColumnName("aircraft_id");

        builder
            .Property(x => x.AirlineId)
            .HasComment("Airline Id")
            .HasColumnName("airline_id");

        builder
            .Property(x => x.RouteId)
            .HasComment("Route Id")
            .HasColumnName("route_id");

        builder
            .Property(x => x.Number)
            .HasComment("Number")
            .HasColumnName("number");

        builder
            .Property(x => x.ScheduledDepartureTime)
            .HasComment("Scheduled Departure Time")
            .HasColumnName("scheduled_departure_time");

        builder
            .Property(x => x.FactDepartureTime)
            .HasComment("Fact Departure Time")
            .HasColumnName("fact_departure_time");

        builder
            .Property(x => x.ScheduledArrivalTime)
            .HasComment("Scheduled Arrival Time")
            .HasColumnName("scheduled_arrival_time");

        builder
            .Property(x => x.FactArrivalTime)
            .HasComment("Fact Arrival Time")
            .HasColumnName("fact_arrival_time");

        builder.ToTable("flights",
            t => t.HasComment("Flights"));

        builder.HasOne(x => x.Aircraft)
            .WithMany()
            .HasForeignKey(x => x.AircraftId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Airline)
            .WithMany()
            .HasForeignKey(x => x.AirlineId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Route)
            .WithMany()
            .HasForeignKey(x => x.RouteId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}