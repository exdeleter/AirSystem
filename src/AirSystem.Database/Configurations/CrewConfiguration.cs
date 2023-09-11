using AirSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirSystem.Database.Configurations;

/// <summary>
/// <see cref="Crew"/> configuration
/// </summary>
internal class CrewConfiguration : IEntityTypeConfiguration<Crew>
{
    public void Configure(EntityTypeBuilder<Crew> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.FlightId)
            .HasComment("Flight Id")
            .HasColumnName("flight_id");

        builder
            .Property(x => x.Pilot)
            .HasComment("Pilot")
            .HasColumnName("pilot");

        builder
            .Property(x => x.Copilot)
            .HasComment("Copilot")
            .HasColumnName("copilot");

        builder.ToTable("crews",
            t => t.HasComment("Crews"));

        builder.HasOne(x => x.Flight)
            .WithMany()
            .HasForeignKey(x => x.FlightId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}