using AirSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirSystem.Database.Configurations;

/// <summary>
/// <see cref="Airport"/> configuration
/// </summary>
internal class AirportConfiguration : IEntityTypeConfiguration<Airport>
{
    public void Configure(EntityTypeBuilder<Airport> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.Name)
            .HasComment("Name")
            .HasColumnName("name");

        builder
            .Property(x => x.ICAOCode)
            .HasComment("ICAO Code")
            .HasColumnName("icao_name");

        builder
            .Property(x => x.IATACode)
            .HasComment("IATA Code")
            .HasColumnName("iata_name");

        builder
            .Property(x => x.CityId)
            .HasComment("City Id")
            .HasColumnName("city_id");

        builder
            .Property(x => x.Latitude)
            .HasComment("Latitude")
            .HasColumnName("latitude");

        builder
            .Property(x => x.Longitude)
            .HasComment("Longitude")
            .HasColumnName("longitude");

        builder
            .Property(x => x.Website)
            .HasComment("Website")
            .HasColumnName("website");

        builder.ToTable("airports",
            t => t.HasComment("Airports"));

        builder.HasOne(x => x.City)
            .WithMany()
            .HasForeignKey(x => x.CityId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}