using Microsoft.EntityFrameworkCore.Migrations;

namespace Show.Data.Migrations
{
    public partial class sub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isSubsribedToNewsLetter",
                table: "Customers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isSubsribedToNewsLetter",
                table: "Customers");
        }
    }
}
