using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Drive.Migrations
{
    public partial class driver_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "WorkEnd",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WorkStart",
                table: "Drivers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkEnd",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "WorkStart",
                table: "Drivers");
        }
    }
}
