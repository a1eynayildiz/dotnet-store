using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_store.Controllers;

public class UrunController : Controller
{
    // Dependecy Injection => DI
    private readonly DataContext _context;
    public UrunController(DataContext context)
    {
        _context = context;
    }

    public ActionResult Index()
    {
        return View();
    }

    public ActionResult List(string url,string q) //route parametreleri url=> value
    {
        /*Query:sunucuya (backend) ne tür bir veri istediğimize dair filtre, arama veya ayar bilgisi göndermektir.*/
        var query = _context.Urunler.Where(i=>i.Aktif).AsQueryable();
        if (!string.IsNullOrEmpty(url))
        {
           //filtreleme
           query = query.Where(i => i.Kategori.Url == url);
        }

        if (!string.IsNullOrEmpty(q))
        {
            query = query.Where(i => i.UrunAdi.ToLower().Contains(q.ToLower()));//Gönderdiğimiz kelime ör 8 kelime içerisinde aranır.
        ViewData["q"]=q;
        }
            
        // var urunler = _context.Urunler.Where(i=>i.Aktif && i.Kategori.Url == url).ToList();
        return View(query.ToList());//elimizde artık bir query değil bir list var
    }

    public ActionResult Details(int id)
    {
        // var urun = _context.Urunler.FirstOrDefault(i => i.Id == id);
        var urun = _context.Urunler.Find(id);//sadece id'ye göre atama yapmak istersek kullanırız.
        
        if(urun == null)
        {
            return RedirectToAction("List");
        }

        ViewData["BenzerUrunler"] = _context.Urunler.Where(i=>i.KategoriId == urun.KategoriId &&i.Id != id)
        .Take(4)
        .ToList();

        return View(urun);
    }
}