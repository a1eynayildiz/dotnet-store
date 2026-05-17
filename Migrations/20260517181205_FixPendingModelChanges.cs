using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class FixPendingModelChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1,
                column: "Aciklama",
                value: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos error id porro aspernatur ipsam. In eius aliquam sit eveniet et esse voluptatum veritatis eum temporibus tempora nihil recusandae, deleniti qui?");

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos error id porro aspernatur ipsam. In eius aliquam sit eveniet et esse voluptatum veritatis eum temporibus tempora nihil recusandae, deleniti qui?", true, "2.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos error id porro aspernatur ipsam. In eius aliquam sit eveniet et esse voluptatum veritatis eum temporibus tempora nihil recusandae, deleniti qui?", true, "3.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos error id porro aspernatur ipsam. In eius aliquam sit eveniet et esse voluptatum veritatis eum temporibus tempora nihil recusandae, deleniti qui?", true, "4.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos error id porro aspernatur ipsam. In eius aliquam sit eveniet et esse voluptatum veritatis eum temporibus tempora nihil recusandae, deleniti qui?", true, "5.jpeg" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos error id porro aspernatur ipsam. In eius aliquam sit eveniet et esse voluptatum veritatis eum temporibus tempora nihil recusandae, deleniti qui?", true, "6.jpeg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1,
                column: "Aciklama",
                value: null);

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { null, false, null });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Aciklama", "Anasayfa", "Resim" },
                values: new object[] { null, false, null });
        }
    }
}
