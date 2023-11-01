using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadService.Migrations
{
    /// <inheritdoc />
    public partial class AddTimeTableItemTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeTimeTableItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTimeTableItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmployeeTimeTableItems_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResourceTimeTableItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ResourceId = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceTimeTableItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResourceTimeTableItems_Resources_ResourceId",
                        column: x => x.ResourceId,
                        principalTable: "Resources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTimeTableItems_EmployeeId",
                table: "EmployeeTimeTableItems",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResourceTimeTableItems_ResourceId",
                table: "ResourceTimeTableItems",
                column: "ResourceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeTimeTableItems");

            migrationBuilder.DropTable(
                name: "ResourceTimeTableItems");

            migrationBuilder.DropTable(
                name: "Resources");
        }
    }
}
