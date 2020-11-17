using Microsoft.EntityFrameworkCore.Migrations;

namespace Post_2.Migrations
{
    public partial class postlike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "commentLikes",
                table: "comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "commentViews",
                table: "comments",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "commentLikes",
                table: "comments");

            migrationBuilder.DropColumn(
                name: "commentViews",
                table: "comments");
        }
    }
}
