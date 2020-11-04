using Microsoft.EntityFrameworkCore.Migrations;

namespace EF10.Migrations
{
    public partial class modification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_departments_departmentID",
                table: "students");

            migrationBuilder.DropIndex(
                name: "IX_students_departmentID",
                table: "students");

            migrationBuilder.DropColumn(
                name: "departmentID",
                table: "students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmentID",
                table: "students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_students_departmentID",
                table: "students",
                column: "departmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_students_departments_departmentID",
                table: "students",
                column: "departmentID",
                principalTable: "departments",
                principalColumn: "departmentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
