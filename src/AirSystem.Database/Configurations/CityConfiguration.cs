using AirSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirSystem.Database.Configurations;

internal class CityConfiguration : IEntityTypeConfiguration<City>
{
    public void Configure(EntityTypeBuilder<City> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.Name)
            .HasComment("Name")
            .HasColumnName("name");

        builder
            .Property(x => x.CountryId)
            .HasComment("Country id")
            .HasColumnName("country_id");

        builder.ToTable("cities",
            t => t.HasComment("Cities"));

        builder.HasOne(x => x.Country)
            .WithMany()
            .HasForeignKey(x => x.CountryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}