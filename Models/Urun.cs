namespace dotnet_store.Models;
using Microsoft.Extensions.Logging.Abstractions;
public class Urun
{
    public int Id { get; set; }
    public string UrunAdi { get; set; } =null!;
    public double Fiyat { get; set; }
    public bool Aktif { get; set; }
}