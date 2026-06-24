using System.ComponentModel.DataAnnotations;

namespace dotnet_store.Models;

public class UrunCreateModel
{
    [Required(ErrorMessage = "Ürün adı zorunludur.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Ürün adı 2-100 karakter olmalıdır.")]
    public string UrunAdi { get; set; } = null!;

    [Required(ErrorMessage = "Fiyat zorunludur.")]
    [Range(0, double.MaxValue, ErrorMessage = "Fiyat 0'dan küçük olamaz.")]
    public double Fiyat { get; set; }

    public string? Aciklama { get; set; }

    public IFormFile? Resim { get; set; }

    public bool Aktif { get; set; }
    public bool Anasayfa { get; set; }

    [Required(ErrorMessage = "Kategori seçiniz.")]
    [Range(1, int.MaxValue, ErrorMessage = "Kategori seçiniz.")]
    public int KategoriId { get; set; }
}