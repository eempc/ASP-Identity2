using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication2.Migrations.WebApplication2Country
{
    public partial class initialCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LongName = table.Column<string>(nullable: false),
                    ShortName = table.Column<string>(nullable: false),
                    Continent = table.Column<string>(nullable: false),
                    TwoLetterCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
