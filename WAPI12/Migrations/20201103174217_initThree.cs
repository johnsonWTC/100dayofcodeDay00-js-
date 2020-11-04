using Microsoft.EntityFrameworkCore.Migrations;

namespace WAPI12.Migrations
{
    public partial class initThree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_faculties_FacultyID",
                table: "students");

            migrationBuilder.AlterColumn<int>(
                name: "FacultyID",
                table: "students",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_students_faculties_FacultyID",
                table: "students",
                column: "FacultyID",
                principalTable: "faculties",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_faculties_FacultyID",
                table: "students");

            migrationBuilder.AlterColumn<int>(
                name: "FacultyID",
                table: "students",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_students_faculties_FacultyID",
                table: "students",
                column: "FacultyID",
                principalTable: "faculties",
                principalColumn: "FacultyID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
