using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadService.Migrations
{
    /// <inheritdoc />
    public partial class Task : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActualResourcesId",
                table: "Tasks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Tasks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PlannedResourceId",
                table: "Tasks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualResourcesId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "PlannedResourceId",
                table: "Tasks");
        }
    }
}
