using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirSystem.Database.Migrations
{
    /// <inheritdoc />
    public partial class ChangeModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Airlines_Countries_CountryId",
                table: "Airlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Airports_Countries_CountryId",
                table: "Airports");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Airlines_AirlineId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Airlines",
                table: "Airlines");

            migrationBuilder.DropIndex(
                name: "IX_Airlines_CountryId",
                table: "Airlines");

            migrationBuilder.DropColumn(
                name: "CodeIATA",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Airlines");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Airlines");

            migrationBuilder.RenameTable(
                name: "Airlines",
                newName: "airlines");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Airports",
                newName: "CityId");

            migrationBuilder.RenameColumn(
                name: "CodeIKAO",
                table: "Airports",
                newName: "WebCite");

            migrationBuilder.RenameIndex(
                name: "IX_Airports_CountryId",
                table: "Airports",
                newName: "IX_Airports_CityId");

            migrationBuilder.AlterTable(
                name: "airlines",
                comment: "Airlines");

            migrationBuilder.AddColumn<string>(
                name: "IATACode",
                table: "Airports",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IKAOCode",
                table: "Airports",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "airlines",
                type: "text",
                nullable: true,
                comment: "LogoUrl");

            migrationBuilder.AddColumn<string>(
                name: "callsign",
                table: "airlines",
                type: "text",
                nullable: false,
                defaultValue: "",
                comment: "Callsign");

            migrationBuilder.AddColumn<Guid>(
                name: "city_id",
                table: "airlines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                comment: "City Id");

            migrationBuilder.AddColumn<string>(
                name: "full_name",
                table: "airlines",
                type: "text",
                nullable: false,
                defaultValue: "",
                comment: "Full name");

            migrationBuilder.AddColumn<string>(
                name: "iata_name",
                table: "airlines",
                type: "text",
                nullable: false,
                defaultValue: "",
                comment: "IATA Code");

            migrationBuilder.AddColumn<string>(
                name: "icao_name",
                table: "airlines",
                type: "text",
                nullable: false,
                defaultValue: "",
                comment: "ICAO Code");

            migrationBuilder.AddColumn<string>(
                name: "short_name",
                table: "airlines",
                type: "text",
                nullable: false,
                defaultValue: "",
                comment: "Short name");

            migrationBuilder.AddColumn<string>(
                name: "website",
                table: "airlines",
                type: "text",
                nullable: true,
                comment: "Website");

            migrationBuilder.AddColumn<int>(
                name: "MaxSpeed",
                table: "Aircrafts",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_airlines",
                table: "airlines",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    CountryId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_airlines_city_id",
                table: "airlines",
                column: "city_id");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_airlines_City_city_id",
                table: "airlines",
                column: "city_id",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Airports_City_CityId",
                table: "Airports",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_airlines_AirlineId",
                table: "Flights",
                column: "AirlineId",
                principalTable: "airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_airlines_City_city_id",
                table: "airlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Airports_City_CityId",
                table: "Airports");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_airlines_AirlineId",
                table: "Flights");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_airlines",
                table: "airlines");

            migrationBuilder.DropIndex(
                name: "IX_airlines_city_id",
                table: "airlines");

            migrationBuilder.DropColumn(
                name: "IATACode",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "IKAOCode",
                table: "Airports");

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "airlines");

            migrationBuilder.DropColumn(
                name: "callsign",
                table: "airlines");

            migrationBuilder.DropColumn(
                name: "city_id",
                table: "airlines");

            migrationBuilder.DropColumn(
                name: "full_name",
                table: "airlines");

            migrationBuilder.DropColumn(
                name: "iata_name",
                table: "airlines");

            migrationBuilder.DropColumn(
                name: "icao_name",
                table: "airlines");

            migrationBuilder.DropColumn(
                name: "short_name",
                table: "airlines");

            migrationBuilder.DropColumn(
                name: "website",
                table: "airlines");

            migrationBuilder.DropColumn(
                name: "MaxSpeed",
                table: "Aircrafts");

            migrationBuilder.RenameTable(
                name: "airlines",
                newName: "Airlines");

            migrationBuilder.RenameColumn(
                name: "WebCite",
                table: "Airports",
                newName: "CodeIKAO");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Airports",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Airports_CityId",
                table: "Airports",
                newName: "IX_Airports_CountryId");

            migrationBuilder.AlterTable(
                name: "Airlines",
                oldComment: "Airlines");

            migrationBuilder.AddColumn<string>(
                name: "CodeIATA",
                table: "Airports",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "CountryId",
                table: "Airlines",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Airlines",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Airlines",
                table: "Airlines",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Airlines_CountryId",
                table: "Airlines",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Airlines_Countries_CountryId",
                table: "Airlines",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Airports_Countries_CountryId",
                table: "Airports",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Airlines_AirlineId",
                table: "Flights",
                column: "AirlineId",
                principalTable: "Airlines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
