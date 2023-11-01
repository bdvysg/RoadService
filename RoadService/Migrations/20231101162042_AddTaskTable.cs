using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadService.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    PlannedPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    ActualPrice = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "Tasks");

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
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "PlannedResourceId",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Employees");
        }
    }
}
