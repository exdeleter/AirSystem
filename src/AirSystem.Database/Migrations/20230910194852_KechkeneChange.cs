using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirSystem.Database.Migrations
{
    /// <inheritdoc />
    public partial class KechkeneChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FactArrivalTime",
                table: "flights");

            migrationBuilder.RenameColumn(
                name: "ScheduledArrivalTime",
                table: "flights",
                newName: "scheduled_arrival_time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fact_arrival_time",
                table: "flights",
                type: "timestamp with time zone",
                nullable: true,
                comment: "Fact Arrival Time",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldComment: "Fact Arrival Time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "scheduled_arrival_time",
                table: "flights",
                type: "timestamp with time zone",
                nullable: false,
                comment: "Scheduled Arrival Time",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<DateTime>(
                name: "scheduled_departure_time",
                table: "flights",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Scheduled Departure Time");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "scheduled_departure_time",
                table: "flights");

            migrationBuilder.RenameColumn(
                name: "scheduled_arrival_time",
                table: "flights",
                newName: "ScheduledArrivalTime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fact_arrival_time",
                table: "flights",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "Fact Arrival Time",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldComment: "Fact Arrival Time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ScheduledArrivalTime",
                table: "flights",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldComment: "Scheduled Arrival Time");

            migrationBuilder.AddColumn<DateTime>(
                name: "FactArrivalTime",
                table: "flights",
                type: "timestamp with time zone",
                nullable: true);
        }
    }
}
