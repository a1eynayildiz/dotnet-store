using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_store.Controllers;

public class UrunController : Controller
{
    // Dependecy Injection => DI
    private readonly DataContext _context;
    private readonly IWebHostEnvironment _env;

    public UrunController(DataContext context, IWebHostEnvironment env)
    {
        _context = context;
        _env = env;
    }

    public ActionResult Index()
    {
        var urunler = _context.Urunler.Select(i => new UrunGetModel
        {
            Id = i.Id,
            UrunAdi = i.UrunAdi,
            Fiyat = i.Fiyat,
            Aktif = i.Aktif,
            Anasayfa = i.Anasayfa,
            KategoriId = i.KategoriId,
            KategoriAdi = i.Kategori.KategoriAdi,
            Resim = i.Resim
        }).ToList();
        return View(urunler);
    }

    public ActionResult List(string url, string q) //route parametreleri url=> value
    {
        /*Query:sunucuya (backend) ne tür bir veri istediğimize dair filtre, arama veya ayar bilgisi göndermektir.*/
        var query = _context.Urunler.Where(i => i.Aktif).AsQueryable();
        if (!string.IsNullOrEmpty(url))
        {
            //filtreleme
            query = query.Where(i => i.Kategori.Url == url);
        }

        if (!string.IsNullOrEmpty(q))
        {
            query = query.Where(i => i.UrunAdi.ToLower().Contains(q.ToLower()));//Gönderdiğimiz kelime ör 8 kelime içerisinde aranır.
            ViewData["q"] = q;
        }

        return View(query.ToList());//elimizde artık bir query değil bir list var
    }

    public ActionResult Details(int id)
    {
        var urun = _context.Urunler.Find(id);//sadece id'ye göre atama yapmak istersek kullanırız.

        if (urun == null)
        {
            return RedirectToAction("List");
        }

        ViewData["BenzerUrunler"] = _context.Urunler.Where(i => i.KategoriId == urun.KategoriId && i.Id != id)
            .Take(4)
            .ToList();

        return View(urun);
    }

    [HttpGet]
    public ActionResult Create()
    {
        ViewBag.Kategoriler = _context.Kategoriler.ToList();
        return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(UrunCreateModel model)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Kategoriler = _context.Kategoriler.ToList();
            return View(model);
        }

        var entity = new Urun
        {
            UrunAdi = model.UrunAdi,
            Fiyat = model.Fiyat,
            Aciklama = model.Aciklama,
            Aktif = model.Aktif,
            Anasayfa = model.Anasayfa,
            KategoriId = model.KategoriId,
            Resim = await SaveImageAsync(model.Resim)
        };

        _context.Urunler.Add(entity);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }

    [HttpGet]
    public ActionResult Edit(int id)
    {
        var urun = _context.Urunler.Find(id);
        if (urun == null)
        {
            return RedirectToAction("Index");
        }

        var model = new UrunEditModel
        {
            Id = urun.Id,
            UrunAdi = urun.UrunAdi,
            Fiyat = urun.Fiyat,
            Aciklama = urun.Aciklama,
            Resim = urun.Resim,
            Aktif = urun.Aktif,
            Anasayfa = urun.Anasayfa,
            KategoriId = urun.KategoriId
        };

        ViewBag.Kategoriler = _context.Kategoriler.ToList();
        return View(model);
    }

    [HttpPost]
    public async Task<ActionResult> Edit(UrunEditModel model)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Kategoriler = _context.Kategoriler.ToList();
            return View(model);
        }

        var entity = _context.Urunler.Find(model.Id);
        if (entity == null)
        {
            return RedirectToAction("Index");
        }

        entity.UrunAdi = model.UrunAdi;
        entity.Fiyat = model.Fiyat;
        entity.Aciklama = model.Aciklama;
        entity.Aktif = model.Aktif;
        entity.Anasayfa = model.Anasayfa;
        entity.KategoriId = model.KategoriId;

        if (model.YeniResim != null)
        {
            entity.Resim = await SaveImageAsync(model.YeniResim);
        }

        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpPost]
    public ActionResult Delete(int id)
    {
        var urun = _context.Urunler.Find(id);
        if (urun != null)
        {
            _context.Urunler.Remove(urun);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }

    private async Task<string?> SaveImageAsync(IFormFile? file)
    {
        if (file == null || file.Length == 0) return null;

        var allowed = new[] { ".jpg", ".jpeg", ".png", ".webp" };
        var ext = Path.GetExtension(file.FileName).ToLowerInvariant();
        if (!allowed.Contains(ext)) return null;

        var fileName = $"{Guid.NewGuid()}{ext}";
        var imgFolder = Path.Combine(_env.WebRootPath, "img");
        Directory.CreateDirectory(imgFolder);
        var fullPath = Path.Combine(imgFolder, fileName);

        using var stream = new FileStream(fullPath, FileMode.Create);
        await file.CopyToAsync(stream);
        return fileName;
    }
}