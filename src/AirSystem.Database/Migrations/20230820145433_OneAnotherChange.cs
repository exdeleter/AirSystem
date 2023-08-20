using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirSystem.Database.Migrations
{
    /// <inheritdoc />
    public partial class OneAnotherChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_airlines_City_city_id",
                table: "airlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Airports_City_CityId",
                table: "Airports");

            migrationBuilder.DropForeignKey(
                name: "FK_City_Countries_CountryId",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "countries");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "cities");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "countries",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "cities",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "cities",
                newName: "country_id");

            migrationBuilder.RenameIndex(
                name: "IX_City_CountryId",
                table: "cities",
                newName: "IX_cities_country_id");

            migrationBuilder.AlterTable(
                name: "countries",
                comment: "Countries");

            migrationBuilder.AlterTable(
                name: "cities",
                comment: "Cities");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "countries",
                type: "text",
                nullable: false,
                comment: "Name",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "cities",
                type: "text",
                nullable: false,
                comment: "Name",
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<Guid>(
                name: "country_id",
                table: "cities",
                type: "uuid",
                nullable: false,
                comment: "Country id",
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_countries",
                table: "countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cities",
                table: "cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_airlines_cities_city_id",
                table: "airlines",
                column: "city_id",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Airports_cities_CityId",
                table: "Airports",
                column: "CityId",
                principalTable: "cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_cities_countries_country_id",
                table: "cities",
                column: "country_id",
                principalTable: "countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_airlines_cities_city_id",
                table: "airlines");

            migrationBuilder.DropForeignKey(
                name: "FK_Airports_cities_CityId",
                table: "Airports");

            migrationBuilder.DropForeignKey(
                name: "FK_cities_countries_country_id",
                table: "cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_countries",
                table: "countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cities",
                table: "cities");

            migrationBuilder.RenameTable(
                name: "countries",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "cities",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Countries",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "City",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "country_id",
                table: "City",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_cities_country_id",
                table: "City",
                newName: "IX_City_CountryId");

            migrationBuilder.AlterTable(
                name: "Countries",
                oldComment: "Countries");

            migrationBuilder.AlterTable(
                name: "City",
                oldComment: "Cities");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Countries",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldComment: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "City",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldComment: "Name");

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "City",
                type: "uuid",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldComment: "Country id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_airlines_City_city_id",
                table: "airlines",
                column: "city_id",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Airports_City_CityId",
                table: "Airports",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Countries_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
