using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadService.Migrations
{
    /// <inheritdoc />
    public partial class Task1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Tasks_EmployeeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Tasks_ActualResourcesId",
                table: "Resources");

            migrationBuilder.DropForeignKey(
                name: "FK_Resources_Tasks_PlannedResourceId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_ActualResourcesId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Resources_PlannedResourceId",
                table: "Resources");

            migrationBuilder.DropIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ActualResourcesId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "PlannedResourceId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ActualResourcesId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "PlannedResourceId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "ActualResources",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Employees",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PlannedResources",
                table: "Tasks",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualResources",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "Employees",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "PlannedResources",
                table: "Tasks");

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

            migrationBuilder.AddColumn<int>(
                name: "ActualResourcesId",
                table: "Resources",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlannedResourceId",
                table: "Resources",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Employees",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resources_ActualResourcesId",
                table: "Resources",
                column: "ActualResourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_PlannedResourceId",
                table: "Resources",
                column: "PlannedResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeId",
                table: "Employees",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Tasks_EmployeeId",
                table: "Employees",
                column: "EmployeeId",
                principalTable: "Tasks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Tasks_ActualResourcesId",
                table: "Resources",
                column: "ActualResourcesId",
                principalTable: "Tasks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Resources_Tasks_PlannedResourceId",
                table: "Resources",
                column: "PlannedResourceId",
                principalTable: "Tasks",
                principalColumn: "Id");
        }
    }
}
