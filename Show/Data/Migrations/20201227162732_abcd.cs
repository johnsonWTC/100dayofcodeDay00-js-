using Microsoft.EntityFrameworkCore.Migrations;

namespace Show.Data.Migrations
{
    public partial class abcd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_MemberShipType_MemberShipTypeid",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "MemberShipTypeId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "MemberShipTypeid",
                table: "Customers",
                newName: "MemberShipTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_MemberShipTypeid",
                table: "Customers",
                newName: "IX_Customers_MemberShipTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "id",
                table: "MemberShipType",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "MemberShipTypeId",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(short),
                oldType: "smallint",
                oldNullable: true);

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

            migrationBuilder.RenameColumn(
                name: "MemberShipTypeId",
                table: "Customers",
                newName: "MemberShipTypeid");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_MemberShipTypeId",
                table: "Customers",
                newName: "IX_Customers_MemberShipTypeid");

            migrationBuilder.AlterColumn<short>(
                name: "id",
                table: "MemberShipType",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<short>(
                name: "MemberShipTypeid",
                table: "Customers",
                type: "smallint",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "MemberShipTypeId",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_MemberShipType_MemberShipTypeid",
                table: "Customers",
                column: "MemberShipTypeid",
                principalTable: "MemberShipType",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
