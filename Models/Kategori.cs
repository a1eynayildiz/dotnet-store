namespace dotnet_store.Models;

public class Kategori
{
    public int Id { get; set; }
    public string KategoriAdi { get; set; } = null!;
    public string Url {get;set;} = null!;
    public List<Urun> Uruns { get; set; } = new(); //buraya uruns yazmamız biraz saçma oldu çünkü urun türkçe bir kelime fakat entity bunun sonunda "s" olunca urun tablosuyla ilişkili olduğunu anlıyor. new() ile de initialize etmiş oluyoruz yani bellek üzerinden bir adres tanımlıyoruz.
}

//kategori ve urun arasında bire çok ilişki bulunuyor.Kategori açısından baktığımızda çok(List<>), Ürün açısından baktığımızda tek ilişki görmemiz gerekiyor!