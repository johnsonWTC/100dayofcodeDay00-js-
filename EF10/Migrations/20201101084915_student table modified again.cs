using Microsoft.EntityFrameworkCore.Migrations;

namespace EF10.Migrations
{
    public partial class studenttablemodifiedagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "studentID",
                table: "departments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_departments_studentID",
                table: "departments",
                column: "studentID");

            migrationBuilder.AddForeignKey(
                name: "FK_departments_students_studentID",
                table: "departments",
                column: "studentID",
                principalTable: "students",
                principalColumn: "studentID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_students_studentID",
                table: "departments");

            migrationBuilder.DropIndex(
                name: "IX_departments_studentID",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "studentID",
                table: "departments");
        }
    }
}
