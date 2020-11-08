using Microsoft.EntityFrameworkCore.Migrations;

namespace EF15.Migrations
{
    public partial class initi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_Posts_postID",
                table: "comments");

            migrationBuilder.AlterColumn<int>(
                name: "postID",
                table: "comments",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_comments_Posts_postID",
                table: "comments",
                column: "postID",
                principalTable: "Posts",
                principalColumn: "postID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_Posts_postID",
                table: "comments");

            migrationBuilder.AlterColumn<int>(
                name: "postID",
                table: "comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_comments_Posts_postID",
                table: "comments",
                column: "postID",
                principalTable: "Posts",
                principalColumn: "postID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
