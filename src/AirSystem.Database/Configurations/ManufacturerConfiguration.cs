using AirSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirSystem.Database.Configurations;

/// <summary>
/// <see cref="Manufacturer"/> configuration
/// </summary>
internal class ManufacturerConfiguration : IEntityTypeConfiguration<Manufacturer>
{
    public void Configure(EntityTypeBuilder<Manufacturer> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.Name)
            .HasComment("Name")
            .HasColumnName("name");

        builder.ToTable("manufacturers",
            t => t.HasComment("Manufacturers"));
    }
}