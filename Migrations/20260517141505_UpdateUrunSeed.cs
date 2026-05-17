using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUrunSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Aktif", "Fiyat", "UrunAdi" },
                values: new object[] { false, 10000.0, "Apple Watch 7" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Fiyat", "UrunAdi" },
                values: new object[] { 20000.0, "Apple Watch 8" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Fiyat", "UrunAdi" },
                values: new object[] { 30000.0, "Apple Watch 9" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Aktif", "Fiyat", "UrunAdi" },
                values: new object[] { false, 40000.0, "Apple Watch 10" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Fiyat", "UrunAdi" },
                values: new object[] { 50000.0, "Apple Watch 11" });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "Aktif", "Fiyat", "UrunAdi" },
                values: new object[] { 6, true, 60000.0, "Apple Watch 12" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Aktif", "Fiyat", "UrunAdi" },
                values: new object[] { true, 40000.0, "Apple Watch 8" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Fiyat", "UrunAdi" },
                values: new object[] { 50000.0, "Apple Watch 9" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Fiyat", "UrunAdi" },
                values: new object[] { 60000.0, "Apple Watch 10" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Aktif", "Fiyat", "UrunAdi" },
                values: new object[] { true, 70000.0, "Apple Watch 11" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Fiyat", "UrunAdi" },
                values: new object[] { 80000.0, "Apple Watch 12" });
        }
    }
}
