using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Post_2.Migrations
{
    public partial class newModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "numberofviews",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "postLike",
                table: "Posts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "postTitle",
                table: "Posts",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "timeUpdate",
                table: "Posts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numberofviews",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "postLike",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "postTitle",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "timeUpdate",
                table: "Posts");
        }
    }
}
