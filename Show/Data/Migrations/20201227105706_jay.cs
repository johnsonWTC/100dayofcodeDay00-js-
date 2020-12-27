using Microsoft.EntityFrameworkCore.Migrations;

namespace Show.Data.Migrations
{
    public partial class jay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberShipTypeId",
                table: "Customers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "MemberShipType",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SignUpFee = table.Column<int>(nullable: false),
                    DurationInMonths = table.Column<int>(nullable: false),
                    DiscountInRate = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberShipType", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_MemberShipTypeId",
                table: "Customers",
                column: "MemberShipTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MemberShipType_MemberShipTypeId",
                table: "Customers",
                column: "MemberShipTypeId",
                principalTable: "MemberShipType",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MemberShipType_MemberShipTypeId",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "MemberShipType");

            migrationBuilder.DropIndex(
                name: "IX_Customers_MemberShipTypeId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MemberShipTypeId",
                table: "Customers");
        }
    }
}
