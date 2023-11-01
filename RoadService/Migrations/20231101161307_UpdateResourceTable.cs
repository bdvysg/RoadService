using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadService.Migrations
{
    /// <inheritdoc />
    public partial class UpdateResourceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Resources",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastMaintenanceDate",
                table: "Resources",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LicensePlate",
                table: "Resources",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Manufacturer",
                table: "Resources",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaterialType",
                table: "Resources",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "Resources",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Resources",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnitOfMeasure",
                table: "Resources",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VehicleType",
                table: "Resources",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "LastMaintenanceDate",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "LicensePlate",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "Manufacturer",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "MaterialType",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "UnitOfMeasure",
                table: "Resources");

            migrationBuilder.DropColumn(
                name: "VehicleType",
                table: "Resources");
        }
    }
}
