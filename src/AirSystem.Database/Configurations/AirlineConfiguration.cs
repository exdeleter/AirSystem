using AirSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirSystem.Database.Configurations;

internal class AirlineConfiguration : IEntityTypeConfiguration<Airline>
{
    public void Configure(EntityTypeBuilder<Airline> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.ShortName)
            .HasComment("Short name")
            .HasColumnName("short_name");

        builder
            .Property(x => x.FullName)
            .HasComment("Full name")
            .HasColumnName("full_name");

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
            .Property(x => x.Website)
            .HasComment("Website")
            .HasColumnName("website");

        builder
            .Property(x => x.CallSign)
            .HasComment("Callsign")
            .HasColumnName("callsign");

        builder
            .Property(x => x.LogoUrl)
            .HasComment("LogoUrl")
            .HasColumnName("LogoUrl");

        builder.ToTable("airlines",
            t => t.HasComment("Airlines"));

        builder.HasOne(x => x.City)
            .WithMany()
            .HasForeignKey(x => x.CityId);
    }
}