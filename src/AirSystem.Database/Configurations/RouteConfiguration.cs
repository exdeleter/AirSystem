using AirSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirSystem.Database.Configurations;

/// <summary>
/// <see cref="Route"/> configuration
/// </summary>
internal class RouteConfiguration : IEntityTypeConfiguration<Route>
{
    public void Configure(EntityTypeBuilder<Route> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.DepartureAirportId)
            .HasComment("Departure Airport's Id")
            .HasColumnName("departure_airport_id");

        builder
            .Property(x => x.ArrivalAirportId)
            .HasComment("Arrival airport's Id")
            .HasColumnName("arrival_airport_id");

        builder
            .Property(x => x.Distance)
            .HasComment("Distance")
            .HasColumnName("distance");

        builder
            .Property(x => x.Duration)
            .HasComment("Duration")
            .HasColumnName("duration");

        builder.ToTable("routes",
            t => t.HasComment("Routes"));

        builder.HasOne(x => x.DepartureAirport)
            .WithMany()
            .HasForeignKey(x => x.DepartureAirportId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.ArrivalAirport)
            .WithMany()
            .HasForeignKey(x => x.ArrivalAirportId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}