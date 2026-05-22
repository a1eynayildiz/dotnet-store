using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUrunKategori : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                column: "KategoriId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                column: "KategoriId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                column: "KategoriId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                column: "KategoriId",
                value: 4);
        }
    }
}
