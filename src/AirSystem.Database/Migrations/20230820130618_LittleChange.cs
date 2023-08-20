using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AirSystem.Database.Migrations
{
    /// <inheritdoc />
    public partial class LittleChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_airlines_City_city_id",
                table: "airlines");

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Airports",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Airports",
                type: "double precision",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddForeignKey(
                name: "FK_airlines_City_city_id",
                table: "airlines",
                column: "city_id",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_airlines_City_city_id",
                table: "airlines");

            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "Airports",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "Airports",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AddForeignKey(
                name: "FK_airlines_City_city_id",
                table: "airlines",
                column: "city_id",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
