using Microsoft.EntityFrameworkCore.Migrations;

namespace PostAndComments.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    postID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    postContent = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.postID);
                });

            migrationBuilder.CreateTable(
                name: "comments",
                columns: table => new
                {
                    commentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comment = table.Column<string>(nullable: true),
                    postID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comments", x => x.commentID);
                    table.ForeignKey(
                        name: "FK_comments_Posts_postID",
                        column: x => x.postID,
                        principalTable: "Posts",
                        principalColumn: "postID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comments_postID",
                table: "comments",
                column: "postID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comments");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
