using Microsoft.EntityFrameworkCore.Migrations;

namespace Drive.Migrations
{
    public partial class driver_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Drivers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Drivers");
        }
    }
}
