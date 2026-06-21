namespace dotnet_store.Controllers;

using dotnet_store.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class KategoriController:Controller
{
    private readonly DataContext _context;
    public KategoriController(DataContext context)
    {
        _context=context;//dependency injection
    }
    public ActionResult Index()
    {
        var kategoriler = _context.Kategoriler.Select(i=> new KategoriGetModel
        {
            Id = i.Id,
            KategoriAdi = i.KategoriAdi,
            Url = i.Url,
            UrunSayisi =i.Uruns.Count

        }).ToList();// her şeyi getirmek için tolist yazıldı.Ve Kategorileri alırken o aktegorinin ürünlerini de almak için Include kullanıldı.
        return View(kategoriler);
    }
    [HttpGet]
    public ActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Create(string kategoriAdi, string kategoriUrl)
    {
        var entity= new Kategori
        {
            KategoriAdi= kategoriAdi,
            Url=kategoriUrl
        };
        _context.Kategoriler.Add(entity);
        _context.SaveChanges();//değişiklikleri veritabanına kaydeder.
        
        return View();
    }
}