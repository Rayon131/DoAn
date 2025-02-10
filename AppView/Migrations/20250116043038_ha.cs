using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppView.Migrations
{
    /// <inheritdoc />
    public partial class ha : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatPhongs_TaiKhoans_taiKhoannID",
                table: "DatPhongs");

            migrationBuilder.DropIndex(
                name: "IX_DatPhongs_taiKhoannID",
                table: "DatPhongs");

            migrationBuilder.DropColumn(
                name: "taiKhoannID",
                table: "DatPhongs");

            migrationBuilder.CreateIndex(
                name: "IX_DatPhongs_tkId",
                table: "DatPhongs",
                column: "tkId");

            migrationBuilder.AddForeignKey(
                name: "FK_DatPhongs_TaiKhoans_tkId",
                table: "DatPhongs",
                column: "tkId",
                principalTable: "TaiKhoans",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DatPhongs_TaiKhoans_tkId",
                table: "DatPhongs");

            migrationBuilder.DropIndex(
                name: "IX_DatPhongs_tkId",
                table: "DatPhongs");

            migrationBuilder.AddColumn<int>(
                name: "taiKhoannID",
                table: "DatPhongs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DatPhongs_taiKhoannID",
                table: "DatPhongs",
                column: "taiKhoannID");

            migrationBuilder.AddForeignKey(
                name: "FK_DatPhongs_TaiKhoans_taiKhoannID",
                table: "DatPhongs",
                column: "taiKhoannID",
                principalTable: "TaiKhoans",
                principalColumn: "ID");
        }
    }
}
