using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations.WebApplication2Country
{
    public partial class UserIDrecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Country",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Country");
        }
    }
}
