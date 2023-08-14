using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TripPlannerWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangesCountryEntityAddISOCodes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsoCodeAlpha2",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IsoCodeAlpha3",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "IsoCodeNum",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsoCodeAlpha2",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "IsoCodeAlpha3",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "IsoCodeNum",
                table: "Countries");
        }
    }
}
