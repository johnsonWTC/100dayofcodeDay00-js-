using Microsoft.EntityFrameworkCore.Migrations;

namespace WAPI12.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "faculties",
                columns: table => new
                {
                    FacultyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacultyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_faculties", x => x.FacultyID);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    studentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    facultyName = table.Column<string>(nullable: true),
                    FacultyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.studentID);
                    table.ForeignKey(
                        name: "FK_students_faculties_FacultyID",
                        column: x => x.FacultyID,
                        principalTable: "faculties",
                        principalColumn: "FacultyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_students_FacultyID",
                table: "students",
                column: "FacultyID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "faculties");
        }
    }
}
