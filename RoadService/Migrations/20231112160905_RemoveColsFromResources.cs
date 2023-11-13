using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadService.Migrations
{
    /// <inheritdoc />
    public partial class RemoveColsFromResources : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaterialType",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "Resources");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaterialType",
                table: "Resources",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Resources",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "Resources",
                type: "TEXT",
                nullable: true);
        }
    }
}
