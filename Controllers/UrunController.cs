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
        var urun = _context.Urunler.FirstOrDefault(u => u.Id == id);
        if (urun == null)
        {
            return NotFound();
        }

        return View(urun);
    }
}