using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace dotnet_store.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUrunKategori2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6,
                column: "KategoriAdi",
                value: "Kategori 1");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7,
                column: "KategoriAdi",
                value: "Kategori 2");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 8,
                column: "KategoriAdi",
                value: "Kategori 3");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 9,
                column: "KategoriAdi",
                value: "Kategori 4");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 10,
                column: "KategoriAdi",
                value: "Kategori 5");

            migrationBuilder.UpdateData(
                table: "Sliderlar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Aciklama", "Baslik" },
                values: new object[] { "Slider 1 Açıklama", "Slider 1 Başlık" });

            migrationBuilder.UpdateData(
                table: "Sliderlar",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Aciklama", "Baslik" },
                values: new object[] { "Slider 2 Açıklama", "Slider 2 Başlık" });

            migrationBuilder.UpdateData(
                table: "Sliderlar",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Aciklama", "Baslik" },
                values: new object[] { "Slider 3 Açıklama", "Slider 3 Başlık" });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 1,
                column: "Aciklama",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?");

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Aciklama", "KategoriId" },
                values: new object[] { "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", 1 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                column: "Aciklama",
                value: "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?");

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Aciklama", "Anasayfa" },
                values: new object[] { "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", false });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Aciklama", "KategoriId" },
                values: new object[] { "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", 2 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Aciklama", "Aktif", "Anasayfa", "KategoriId" },
                values: new object[] { "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", false, false, 3 });

            migrationBuilder.InsertData(
                table: "Urunler",
                columns: new[] { "Id", "Aciklama", "Aktif", "Anasayfa", "Fiyat", "KategoriId", "Resim", "UrunAdi" },
                values: new object[,]
                {
                    { 7, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", false, false, 70000.0, 3, "7.jpeg", "Apple Watch 14" },
                    { 8, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Nobis quam accusamus neque tempore, consequatur dolor, nihil impedit recusandae ad adipisci eveniet libero ipsum quidem optio laboriosam, ea ipsa ducimus iusto?", true, true, 80000.0, 4, "8.jpeg", "Apple Watch 15" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 6,
                column: "KategoriAdi",
                value: "Kategori 1 ");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 7,
                column: "KategoriAdi",
                value: "Kategori 2 ");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 8,
                column: "KategoriAdi",
                value: "Kategori 3 ");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 9,
                column: "KategoriAdi",
                value: "Kategori 4 ");

            migrationBuilder.UpdateData(
                table: "Kategoriler",
                keyColumn: "Id",
                keyValue: 10,
                column: "KategoriAdi",
                value: "Kategori 5 ");

            migrationBuilder.UpdateData(
                table: "Sliderlar",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Aciklama", "Baslik" },
                values: new object[] { "Slider 1 açıklama", "Slider 1 başlık" });

            migrationBuilder.UpdateData(
                table: "Sliderlar",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Aciklama", "Baslik" },
                values: new object[] { "Slider 2 açıklama", "Slider 2 başlık" });

            migrationBuilder.UpdateData(
                table: "Sliderlar",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Aciklama", "Baslik" },
                values: new object[] { "Slider 3 açıklama", "Slider 3 başlık" });

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
                columns: new[] { "Aciklama", "KategoriId" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos error id porro aspernatur ipsam. In eius aliquam sit eveniet et esse voluptatum veritatis eum temporibus tempora nihil recusandae, deleniti qui?", 2 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 3,
                column: "Aciklama",
                value: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos error id porro aspernatur ipsam. In eius aliquam sit eveniet et esse voluptatum veritatis eum temporibus tempora nihil recusandae, deleniti qui?");

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Aciklama", "Anasayfa" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos error id porro aspernatur ipsam. In eius aliquam sit eveniet et esse voluptatum veritatis eum temporibus tempora nihil recusandae, deleniti qui?", true });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Aciklama", "KategoriId" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos error id porro aspernatur ipsam. In eius aliquam sit eveniet et esse voluptatum veritatis eum temporibus tempora nihil recusandae, deleniti qui?", 5 });

            migrationBuilder.UpdateData(
                table: "Urunler",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Aciklama", "Aktif", "Anasayfa", "KategoriId" },
                values: new object[] { "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dignissimos error id porro aspernatur ipsam. In eius aliquam sit eveniet et esse voluptatum veritatis eum temporibus tempora nihil recusandae, deleniti qui?", true, true, 6 });
        }
    }
}
