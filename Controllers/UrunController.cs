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

    public ActionResult List()
    {
        var urunler = _context.Urunler.Where(i=>i.Aktif).ToList();
        return View(urunler);
    }

    public ActionResult Details(int id)
    {
        // var urun = _context.Urunler.FirstOrDefault(i => i.Id == id);
        var urun = _context.Urunler.Find(id);//sadece id'ye göre atama yapmak istersek kullanırız.
        if (urun == null)
        {
            return NotFound();
        }

        return View(urun);
    }
}