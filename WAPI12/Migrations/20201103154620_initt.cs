using Microsoft.EntityFrameworkCore.Migrations;

namespace WAPI12.Migrations
{
    public partial class initt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "facultyName",
                table: "students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "facultyName",
                table: "students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
