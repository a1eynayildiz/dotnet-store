using Microsoft.EntityFrameworkCore;
namespace dotnet_store.Models;

/*DataContext sınıfı,Entityframework Core'un DbContext sınıfından türetilir.DbContext ile veritabanı işlemleri yapılır.*/
public class DataContext:DbContext 
{
    //yapıcı metot(constructor)
    public DataContext(DbContextOptions<DataContext> options):base(options)
    {
        
    }
    public DbSet<Urun> Urunler { get; set; }
}


// //bu sınıfı kullanabilmek için bir nesne üretmeliyiz.
// DataContext _context = new DataContext();