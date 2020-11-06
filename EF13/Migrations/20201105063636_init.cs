using Microsoft.EntityFrameworkCore.Migrations;

namespace EF13.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "roomNumbers",
                columns: table => new
                {
                    roomNumberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roomName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roomNumbers", x => x.roomNumberID);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    studentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentName = table.Column<string>(nullable: true),
                    roomNumberID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.studentID);
                    table.ForeignKey(
                        name: "FK_students_roomNumbers_roomNumberID",
                        column: x => x.roomNumberID,
                        principalTable: "roomNumbers",
                        principalColumn: "roomNumberID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_students_roomNumberID",
                table: "students",
                column: "roomNumberID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "roomNumbers");
        }
    }
}
