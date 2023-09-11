using AirSystem.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AirSystem.Database.Configurations;

/// <summary>
/// <see cref="Passenger"/> configuration
/// </summary>
internal class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
{
    public void Configure(EntityTypeBuilder<Passenger> builder)
    {
        builder.HasKey(x => x.Id);

        builder
            .Property(x => x.FlightId)
            .HasComment("Flight Id")
            .HasColumnName("flight_id");

        builder
            .Property(x => x.FirstName)
            .HasComment("First Name")
            .HasColumnName("first_name");

        builder
            .Property(x => x.LastName)
            .HasComment("Last Name")
            .HasColumnName("last_name");

        builder
            .Property(x => x.SeatNumber)
            .HasComment("Seat number")
            .HasColumnName("seat_number");

        builder.ToTable("passengers",
            t => t.HasComment("Passengers"));

        builder.HasOne(x => x.Flight)
            .WithMany()
            .HasForeignKey(x => x.FlightId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}