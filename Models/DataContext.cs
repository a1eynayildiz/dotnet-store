using Microsoft.EntityFrameworkCore;
namespace dotnet_store.Models;

/*DataContext sınıfı,Entityframework Core'un DbContext sınıfından türetilir.DbContext ile veritabanı işlemleri yapılır.*/
public class DataContext:DbContext 
{
    public DbSet<Urun> Urunler { get; set; }
    
    
}