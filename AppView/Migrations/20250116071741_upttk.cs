using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppView.Migrations
{
    /// <inheritdoc />
    public partial class upttk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatPhongs_TaiKhoans_tkId",
                table: "DatPhongs");

            migrationBuilder.AlterColumn<int>(
                name: "tkId",
                table: "DatPhongs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DatPhongs_TaiKhoans_tkId",
                table: "DatPhongs",
                column: "tkId",
                principalTable: "TaiKhoans",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatPhongs_TaiKhoans_tkId",
                table: "DatPhongs");

            migrationBuilder.AlterColumn<int>(
                name: "tkId",
                table: "DatPhongs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_DatPhongs_TaiKhoans_tkId",
                table: "DatPhongs",
                column: "tkId",
                principalTable: "TaiKhoans",
                principalColumn: "ID");
        }
    }
}
