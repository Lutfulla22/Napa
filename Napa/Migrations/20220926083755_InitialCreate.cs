using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Napa.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usernam",
                table: "Logins",
                newName: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Logins",
                newName: "Usernam");
        }
    }
}
