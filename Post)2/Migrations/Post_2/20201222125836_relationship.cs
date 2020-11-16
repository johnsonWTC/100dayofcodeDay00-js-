using Microsoft.EntityFrameworkCore.Migrations;

namespace Post_2.Migrations.Post_2
{
    public partial class relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_Posts_postID",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "postID",
                table: "Posts",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Posts",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_Posts_postID",
                table: "comments",
                column: "postID",
                principalTable: "Posts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comments_Posts_postID",
                table: "comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "id",
                table: "Posts");

            migrationBuilder.AlterColumn<int>(
                name: "postID",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "postID");

            migrationBuilder.AddForeignKey(
                name: "FK_comments_Posts_postID",
                table: "comments",
                column: "postID",
                principalTable: "Posts",
                principalColumn: "postID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
