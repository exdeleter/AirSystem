using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirSystem.Database.Migrations
{
    /// <inheritdoc />
    public partial class ReleaseModelMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aircrafts_Manufacturers_ManufacturerId",
                table: "Aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_Airports_cities_CityId",
                table: "Airports");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Aircrafts_AircraftId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Routes_RouteId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_airlines_AirlineId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Airports_ArrivalAirportId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Airports_DepartureAirportId",
                table: "Routes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Routes",
                table: "Routes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flights",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Airports",
                table: "Airports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Aircrafts",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "IKAOCode",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "WebCite",
                table: "Airports");

            migrationBuilder.RenameTable(
                name: "Routes",
                newName: "routes");

            migrationBuilder.RenameTable(
                name: "Manufacturers",
                newName: "manufacturers");

            migrationBuilder.RenameTable(
                name: "Flights",
                newName: "flights");

            migrationBuilder.RenameTable(
                name: "Airports",
                newName: "airports");

            migrationBuilder.RenameTable(
                name: "Aircrafts",
                newName: "aircrafts");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "routes",
                newName: "duration");

            migrationBuilder.RenameColumn(
                name: "Distance",
                table: "routes",
                newName: "distance");

            migrationBuilder.RenameColumn(
                name: "DepartureAirportId",
                table: "routes",
                newName: "departure_airport_id");

            migrationBuilder.RenameColumn(
                name: "ArrivalAirportId",
                table: "routes",
                newName: "arrival_airport_id");

            migrationBuilder.RenameIndex(
                name: "IX_Routes_DepartureAirportId",
                table: "routes",
                newName: "IX_routes_departure_airport_id");

            migrationBuilder.RenameIndex(
                name: "IX_Routes_ArrivalAirportId",
                table: "routes",
                newName: "IX_routes_arrival_airport_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "manufacturers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "flights",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "ScheduledDepartureTime",
                table: "flights",
                newName: "fact_arrival_time");

            migrationBuilder.RenameColumn(
                name: "RouteId",
                table: "flights",
                newName: "route_id");

            migrationBuilder.RenameColumn(
                name: "FactDepartureTime",
                table: "flights",
                newName: "fact_departure_time");

            migrationBuilder.RenameColumn(
                name: "AirlineId",
                table: "flights",
                newName: "airline_id");

            migrationBuilder.RenameColumn(
                name: "AircraftId",
                table: "flights",
                newName: "aircraft_id");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_RouteId",
                table: "flights",
                newName: "IX_flights_route_id");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_AirlineId",
                table: "flights",
                newName: "IX_flights_airline_id");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_AircraftId",
                table: "flights",
                newName: "IX_flights_aircraft_id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "airports",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "airports",
                newName: "longitude");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "airports",
                newName: "latitude");

            migrationBuilder.RenameColumn(
                name: "IATACode",
                table: "airports",
                newName: "iata_name");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "airports",
                newName: "city_id");

            migrationBuilder.RenameIndex(
                name: "IX_Airports_CityId",
                table: "airports",
                newName: "IX_airports_city_id");

            migrationBuilder.RenameColumn(
                name: "LogoUrl",
                table: "airlines",
                newName: "logo_url");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "aircrafts",
                newName: "model");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "aircrafts",
                newName: "capacity");

            migrationBuilder.RenameColumn(
                name: "ReleaseYear",
                table: "aircrafts",
                newName: "release_year");

            migrationBuilder.RenameColumn(
                name: "RegistrationCode",
                table: "aircrafts",
                newName: "registration_code");

            migrationBuilder.RenameColumn(
                name: "MaxSpeed",
                table: "aircrafts",
                newName: "max_speed");

            migrationBuilder.RenameColumn(
                name: "ManufacturerId",
                table: "aircrafts",
                newName: "manufacturer_id");

            migrationBuilder.RenameIndex(
                name: "IX_Aircrafts_ManufacturerId",
                table: "aircrafts",
                newName: "IX_aircrafts_manufacturer_id");

            migrationBuilder.AlterTable(
                name: "routes",
                comment: "Routes");

            migrationBuilder.AlterTable(
                name: "manufacturers",
                comment: "Manufacturers");

            migrationBuilder.AlterTable(
                name: "flights",
                comment: "Flights");

            migrationBuilder.AlterTable(
                name: "airports",
                comment: "Airports");

            migrationBuilder.AlterTable(
                name: "aircrafts",
                comment: "Airlcrafts");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "duration",
                table: "routes",
                type: "interval",
                nullable: false,
                comment: "Duration",
                oldClrType: typeof(TimeSpan),
                oldType: "interval");

            migrationBuilder.AlterColumn<double>(
                name: "distance",
                table: "routes",
                type: "double precision",
                nullable: false,
                comment: "Distance",
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<Guid>(
                name: "departure_airport_id",
                table: "routes",
                type: "uuid",
                nullable: false,
                comment: "Departure Airport's Id",
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "arrival_airport_id",
                table: "routes",
                type: "uuid",
                nullable: false,
                comment: "Arrival airport's Id",
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "manufacturers",
                type: "text",
                nullable: false,
                comment: "Name",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "number",
                table: "flights",
                type: "text",
                nullable: false,
                comment: "Number",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fact_arrival_time",
                table: "flights",
                type: "timestamp with time zone",
                nullable: false,
                comment: "Fact Arrival Time",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<Guid>(
                name: "route_id",
                table: "flights",
                type: "uuid",
                nullable: false,
                comment: "Route Id",
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fact_departure_time",
                table: "flights",
                type: "timestamp with time zone",
                nullable: true,
                comment: "Fact Departure Time",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "airline_id",
                table: "flights",
                type: "uuid",
                nullable: false,
                comment: "Airline Id",
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "aircraft_id",
                table: "flights",
                type: "uuid",
                nullable: false,
                comment: "Aircraft Id",
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "airports",
                type: "text",
                nullable: false,
                comment: "Name",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<double>(
                name: "longitude",
                table: "airports",
                type: "double precision",
                nullable: false,
                comment: "Longitude",
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "latitude",
                table: "airports",
                type: "double precision",
                nullable: false,
                comment: "Latitude",
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<string>(
                name: "iata_name",
                table: "airports",
                type: "text",
                nullable: true,
                comment: "IATA Code",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "city_id",
                table: "airports",
                type: "uuid",
                nullable: false,
                comment: "City Id",
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddColumn<string>(
                name: "icao_name",
                table: "airports",
                type: "text",
                nullable: true,
                comment: "ICAO Code");

            migrationBuilder.AddColumn<string>(
                name: "website",
                table: "airports",
                type: "text",
                nullable: false,
                defaultValue: "",
                comment: "Website");

            migrationBuilder.AlterColumn<string>(
                name: "model",
                table: "aircrafts",
                type: "text",
                nullable: false,
                comment: "Model",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "capacity",
                table: "aircrafts",
                type: "integer",
                nullable: false,
                comment: "Count of seats",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "release_year",
                table: "aircrafts",
                type: "integer",
                nullable: false,
                comment: "Release Year",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "registration_code",
                table: "aircrafts",
                type: "text",
                nullable: false,
                comment: "Code of registration",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "max_speed",
                table: "aircrafts",
                type: "integer",
                nullable: true,
                comment: "Max Speed",
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "manufacturer_id",
                table: "aircrafts",
                type: "uuid",
                nullable: false,
                comment: "Id of manufacturer",
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_routes",
                table: "routes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_manufacturers",
                table: "manufacturers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_flights",
                table: "flights",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_airports",
                table: "airports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_aircrafts",
                table: "aircrafts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "crews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    flight_id = table.Column<Guid>(type: "uuid", nullable: false, comment: "Flight Id"),
                    pilot = table.Column<string>(type: "text", nullable: false, comment: "Pilot"),
                    copilot = table.Column<string>(type: "text", nullable: false, comment: "Copilot")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_crews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_crews_flights_flight_id",
                        column: x => x.flight_id,
                        principalTable: "flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Crews");

            migrationBuilder.CreateTable(
                name: "passengers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    flight_id = table.Column<Guid>(type: "uuid", nullable: false, comment: "Flight Id"),
                    first_name = table.Column<string>(type: "text", nullable: false, comment: "First Name"),
                    last_name = table.Column<string>(type: "text", nullable: false, comment: "Last Name"),
                    seat_number = table.Column<string>(type: "text", nullable: false, comment: "Seat number")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passengers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_passengers_flights_flight_id",
                        column: x => x.flight_id,
                        principalTable: "flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Passengers");

            migrationBuilder.CreateIndex(
                name: "IX_crews_flight_id",
                table: "crews",
                column: "flight_id");

            migrationBuilder.CreateIndex(
                name: "IX_passengers_flight_id",
                table: "passengers",
                column: "flight_id");

            migrationBuilder.AddForeignKey(
                name: "FK_aircrafts_manufacturers_manufacturer_id",
                table: "aircrafts",
                column: "manufacturer_id",
                principalTable: "manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_airports_cities_city_id",
                table: "airports",
                column: "city_id",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_flights_aircrafts_aircraft_id",
                table: "flights",
                column: "aircraft_id",
                principalTable: "aircrafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_flights_airlines_airline_id",
                table: "flights",
                column: "airline_id",
                principalTable: "airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_flights_routes_route_id",
                table: "flights",
                column: "route_id",
                principalTable: "routes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_routes_airports_arrival_airport_id",
                table: "routes",
                column: "arrival_airport_id",
                principalTable: "airports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_routes_airports_departure_airport_id",
                table: "routes",
                column: "departure_airport_id",
                principalTable: "airports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_aircrafts_manufacturers_manufacturer_id",
                table: "aircrafts");

            migrationBuilder.DropForeignKey(
                name: "FK_airports_cities_city_id",
                table: "airports");

            migrationBuilder.DropForeignKey(
                name: "FK_flights_aircrafts_aircraft_id",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "FK_flights_airlines_airline_id",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "FK_flights_routes_route_id",
                table: "flights");

            migrationBuilder.DropForeignKey(
                name: "FK_routes_airports_arrival_airport_id",
                table: "routes");

            migrationBuilder.DropForeignKey(
                name: "FK_routes_airports_departure_airport_id",
                table: "routes");

            migrationBuilder.DropTable(
                name: "crews");

            migrationBuilder.DropTable(
                name: "passengers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_routes",
                table: "routes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_manufacturers",
                table: "manufacturers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_flights",
                table: "flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_airports",
                table: "airports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_aircrafts",
                table: "aircrafts");

            migrationBuilder.DropColumn(
                name: "icao_name",
                table: "airports");

            migrationBuilder.DropColumn(
                name: "website",
                table: "airports");

            migrationBuilder.RenameTable(
                name: "routes",
                newName: "Routes");

            migrationBuilder.RenameTable(
                name: "manufacturers",
                newName: "Manufacturers");

            migrationBuilder.RenameTable(
                name: "flights",
                newName: "Flights");

            migrationBuilder.RenameTable(
                name: "airports",
                newName: "Airports");

            migrationBuilder.RenameTable(
                name: "aircrafts",
                newName: "Aircrafts");

            migrationBuilder.RenameColumn(
                name: "duration",
                table: "Routes",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "distance",
                table: "Routes",
                newName: "Distance");

            migrationBuilder.RenameColumn(
                name: "departure_airport_id",
                table: "Routes",
                newName: "DepartureAirportId");

            migrationBuilder.RenameColumn(
                name: "arrival_airport_id",
                table: "Routes",
                newName: "ArrivalAirportId");

            migrationBuilder.RenameIndex(
                name: "IX_routes_departure_airport_id",
                table: "Routes",
                newName: "IX_Routes_DepartureAirportId");

            migrationBuilder.RenameIndex(
                name: "IX_routes_arrival_airport_id",
                table: "Routes",
                newName: "IX_Routes_ArrivalAirportId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Manufacturers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "Flights",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "route_id",
                table: "Flights",
                newName: "RouteId");

            migrationBuilder.RenameColumn(
                name: "fact_departure_time",
                table: "Flights",
                newName: "FactDepartureTime");

            migrationBuilder.RenameColumn(
                name: "fact_arrival_time",
                table: "Flights",
                newName: "ScheduledDepartureTime");

            migrationBuilder.RenameColumn(
                name: "airline_id",
                table: "Flights",
                newName: "AirlineId");

            migrationBuilder.RenameColumn(
                name: "aircraft_id",
                table: "Flights",
                newName: "AircraftId");

            migrationBuilder.RenameIndex(
                name: "IX_flights_route_id",
                table: "Flights",
                newName: "IX_Flights_RouteId");

            migrationBuilder.RenameIndex(
                name: "IX_flights_airline_id",
                table: "Flights",
                newName: "IX_Flights_AirlineId");

            migrationBuilder.RenameIndex(
                name: "IX_flights_aircraft_id",
                table: "Flights",
                newName: "IX_Flights_AircraftId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Airports",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "longitude",
                table: "Airports",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "latitude",
                table: "Airports",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "iata_name",
                table: "Airports",
                newName: "IATACode");

            migrationBuilder.RenameColumn(
                name: "city_id",
                table: "Airports",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_airports_city_id",
                table: "Airports",
                newName: "IX_Airports_CityId");

            migrationBuilder.RenameColumn(
                name: "logo_url",
                table: "airlines",
                newName: "LogoUrl");

            migrationBuilder.RenameColumn(
                name: "model",
                table: "Aircrafts",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "capacity",
                table: "Aircrafts",
                newName: "Capacity");

            migrationBuilder.RenameColumn(
                name: "release_year",
                table: "Aircrafts",
                newName: "ReleaseYear");

            migrationBuilder.RenameColumn(
                name: "registration_code",
                table: "Aircrafts",
                newName: "RegistrationCode");

            migrationBuilder.RenameColumn(
                name: "max_speed",
                table: "Aircrafts",
                newName: "MaxSpeed");

            migrationBuilder.RenameColumn(
                name: "manufacturer_id",
                table: "Aircrafts",
                newName: "ManufacturerId");

            migrationBuilder.RenameIndex(
                name: "IX_aircrafts_manufacturer_id",
                table: "Aircrafts",
                newName: "IX_Aircrafts_ManufacturerId");

            migrationBuilder.AlterTable(
                name: "Routes",
                oldComment: "Routes");

            migrationBuilder.AlterTable(
                name: "Manufacturers",
                oldComment: "Manufacturers");

            migrationBuilder.AlterTable(
                name: "Flights",
                oldComment: "Flights");

            migrationBuilder.AlterTable(
                name: "Airports",
                oldComment: "Airports");

            migrationBuilder.AlterTable(
                name: "Aircrafts",
                oldComment: "Airlcrafts");

            migrationBuilder.AlterColumn<TimeSpan>(
                name: "Duration",
                table: "Routes",
                type: "interval",
                nullable: false,
                oldClrType: typeof(TimeSpan),
                oldType: "interval",
                oldComment: "Duration");

            migrationBuilder.AlterColumn<double>(
                name: "Distance",
                table: "Routes",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldComment: "Distance");

            migrationBuilder.AlterColumn<Guid>(
                name: "DepartureAirportId",
                table: "Routes",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldComment: "Departure Airport's Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "ArrivalAirportId",
                table: "Routes",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldComment: "Arrival airport's Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Manufacturers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldComment: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Flights",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldComment: "Number");

            migrationBuilder.AlterColumn<Guid>(
                name: "RouteId",
                table: "Flights",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldComment: "Route Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FactDepartureTime",
                table: "Flights",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true,
                oldComment: "Fact Departure Time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ScheduledDepartureTime",
                table: "Flights",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldComment: "Fact Arrival Time");

            migrationBuilder.AlterColumn<Guid>(
                name: "AirlineId",
                table: "Flights",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldComment: "Airline Id");

            migrationBuilder.AlterColumn<Guid>(
                name: "AircraftId",
                table: "Flights",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldComment: "Aircraft Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Airports",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldComment: "Name");

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Airports",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldComment: "Longitude");

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Airports",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldComment: "Latitude");

            migrationBuilder.AlterColumn<string>(
                name: "IATACode",
                table: "Airports",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true,
                oldComment: "IATA Code");

            migrationBuilder.AlterColumn<Guid>(
                name: "CityId",
                table: "Airports",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldComment: "City Id");

            migrationBuilder.AddColumn<string>(
                name: "IKAOCode",
                table: "Airports",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebCite",
                table: "Airports",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Aircrafts",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldComment: "Model");

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "Aircrafts",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Count of seats");

            migrationBuilder.AlterColumn<int>(
                name: "ReleaseYear",
                table: "Aircrafts",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldComment: "Release Year");

            migrationBuilder.AlterColumn<string>(
                name: "RegistrationCode",
                table: "Aircrafts",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldComment: "Code of registration");

            migrationBuilder.AlterColumn<int>(
                name: "MaxSpeed",
                table: "Aircrafts",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true,
                oldComment: "Max Speed");

            migrationBuilder.AlterColumn<Guid>(
                name: "ManufacturerId",
                table: "Aircrafts",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldComment: "Id of manufacturer");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Routes",
                table: "Routes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Manufacturers",
                table: "Manufacturers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flights",
                table: "Flights",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Airports",
                table: "Airports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aircrafts",
                table: "Aircrafts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Aircrafts_Manufacturers_ManufacturerId",
                table: "Aircrafts",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Airports_cities_CityId",
                table: "Airports",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Aircrafts_AircraftId",
                table: "Flights",
                column: "AircraftId",
                principalTable: "Aircrafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Routes_RouteId",
                table: "Flights",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_airlines_AirlineId",
                table: "Flights",
                column: "AirlineId",
                principalTable: "airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Airports_ArrivalAirportId",
                table: "Routes",
                column: "ArrivalAirportId",
                principalTable: "Airports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Airports_DepartureAirportId",
                table: "Routes",
                column: "DepartureAirportId",
                principalTable: "Airports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
