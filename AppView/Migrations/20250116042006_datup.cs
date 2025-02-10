using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppView.Migrations
{
    /// <inheritdoc />
    public partial class datup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatPhongs_TaiKhoans_TaiKhoannID",
                table: "DatPhongs");

            migrationBuilder.RenameColumn(
                name: "TaiKhoannID",
                table: "DatPhongs",
                newName: "taiKhoannID");

            migrationBuilder.RenameColumn(
                name: "KhachHangId",
                table: "DatPhongs",
                newName: "tkId");

            migrationBuilder.RenameIndex(
                name: "IX_DatPhongs_TaiKhoannID",
                table: "DatPhongs",
                newName: "IX_DatPhongs_taiKhoannID");

            migrationBuilder.AddForeignKey(
                name: "FK_DatPhongs_TaiKhoans_taiKhoannID",
                table: "DatPhongs",
                column: "taiKhoannID",
                principalTable: "TaiKhoans",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatPhongs_TaiKhoans_taiKhoannID",
                table: "DatPhongs");

            migrationBuilder.RenameColumn(
                name: "taiKhoannID",
                table: "DatPhongs",
                newName: "TaiKhoannID");

            migrationBuilder.RenameColumn(
                name: "tkId",
                table: "DatPhongs",
                newName: "KhachHangId");

            migrationBuilder.RenameIndex(
                name: "IX_DatPhongs_taiKhoannID",
                table: "DatPhongs",
                newName: "IX_DatPhongs_TaiKhoannID");

            migrationBuilder.AddForeignKey(
                name: "FK_DatPhongs_TaiKhoans_TaiKhoannID",
                table: "DatPhongs",
                column: "TaiKhoannID",
                principalTable: "TaiKhoans",
                principalColumn: "ID");
        }
    }
}
