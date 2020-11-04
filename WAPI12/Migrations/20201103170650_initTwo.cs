using Microsoft.EntityFrameworkCore.Migrations;

namespace WAPI12.Migrations
{
    public partial class initTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "studentName",
                table: "students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "studentName",
                table: "students");
        }
    }
}
