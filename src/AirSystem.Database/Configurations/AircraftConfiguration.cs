using AirSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirSystem.Database.Configurations;

/// <summary>
/// <see cref="Aircraft"/> configuration
/// </summary>
internal class AircraftConfiguration : IEntityTypeConfiguration<Aircraft>
{
    public void Configure(EntityTypeBuilder<Aircraft> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.RegistrationCode)
            .HasComment("Code of registration")
            .HasColumnName("registration_code");

        builder
            .Property(x => x.ManufacturerId)
            .HasComment("Id of manufacturer")
            .HasColumnName("manufacturer_id");

        builder
            .Property(x => x.Model)
            .HasComment("Model")
            .HasColumnName("model");

        builder
            .Property(x => x.Capacity)
            .HasComment("Count of seats")
            .HasColumnName("capacity");

        builder
            .Property(x => x.ReleaseYear)
            .HasComment("Release Year")
            .HasColumnName("release_year");

        builder
            .Property(x => x.MaxSpeed)
            .HasComment("Max Speed")
            .HasColumnName("max_speed");

        builder.ToTable("aircrafts",
            t => t.HasComment("Airlcrafts"));

        builder.HasOne(x => x.Manufacturer)
            .WithMany()
            .HasForeignKey(x => x.ManufacturerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}