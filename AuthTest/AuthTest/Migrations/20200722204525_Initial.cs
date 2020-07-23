using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthTest.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    idToken = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    provider = table.Column<string>(nullable: true),
                    token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
