# dotnet-store

ASP.NET Core 9 MVC ile geliştirilmiş, kategorilere ayrılmış bir e-ticaret mağazası ve admin paneli. Entity Framework Core (SQLite) üzerinde code-first migration ve seed verisi ile çalışır.

## Özellikler

### Mağaza (Storefront)
- Ana sayfada öne çıkan ürünlerin (`Anasayfa = true`) listelenmesi
- Kategori bazlı ürün listeleme: `/urunler/{kategori-url}`
- Anahtar kelime ile ürün arama (`?q=...`)
- Ürün detay sayfası ve aynı kategoriden benzer ürünler
- Slider ve dinamik kategori menüsü (ViewComponent'ler)

### Admin Panel
- Dashboard (özet kartlar + son siparişler partial'ı)
- **Kategori CRUD**: liste + ekleme
- **Ürün yönetimi**: liste, ekleme, düzenleme, silme
  - Resim yükleme (`wwwroot/img/` altına GUID isimli dosya)
  - Kategori dropdown'u, `Aktif` / `Anasayfa` checkbox'ları
  - DataAnnotations ile sunucu tarafı validation
  - Whitelisted dosya uzantısı (`.jpg`, `.jpeg`, `.png`, `.webp`)

## Teknolojiler

| Katman | Kullanılan |
|--------|------------|
| Framework | ASP.NET Core 9 (MVC) |
| ORM | Entity Framework Core 9 |
| Veritabanı | SQLite |
| UI | Razor Views, Bootstrap 5.3, Font Awesome 6 |
| Pattern | MVC + DTO/ViewModel + ViewComponent |

## Proje Yapısı

```
dotnet-store/
├── Controllers/
│   ├── AdminController.cs
│   ├── HomeController.cs
│   ├── KategoriController.cs
│   └── UrunController.cs
├── Models/
│   ├── DataContext.cs        # EF Core DbContext + Seed
│   ├── Urun.cs               # Ürün entity
│   ├── Kategori.cs           # Kategori entity (1-N → Urun)
│   ├── Slider.cs
│   ├── Urun/
│   │   ├── UrunGetModel.cs   # Listeleme DTO
│   │   ├── UrunCreateModel.cs
│   │   └── UrunEditModel.cs
│   └── Kategori/
│       └── KategoriGetModel.cs
├── ViewComponents/
│   ├── Navbar.cs
│   └── Slider.cs
├── Views/
│   ├── Admin/                # Dashboard
│   ├── Home/                 # Storefront ana sayfa
│   ├── Kategori/             # Kategori admin
│   ├── Urun/                 # Ürün admin (Index/Create/Edit) + Details/List
│   └── Shared/
│       ├── _SiteLayout.cshtml
│       ├── _AdminLayout.cshtml
│       ├── Components/       # ViewComponent şablonları
│       └── Partials/         # Site & Admin partial'ları
├── Migrations/               # EF Core migration'ları
├── wwwroot/                  # Statik dosyalar, css, js, img
├── Program.cs
└── dotnet-store.csproj
```

## Kurulum

### Önkoşullar
- [.NET 9 SDK](https://dotnet.microsoft.com/download)

### Çalıştırma

```bash
git clone https://github.com/<kullanici-adi>/dotnet-store.git
cd dotnet-store
dotnet restore
dotnet ef database update      # Migration'ları uygula (SQLite store.db oluşur)
dotnet run
```

`dotnet ef` yüklü değilse:
```bash
dotnet tool install --global dotnet-ef
```

Uygulama varsayılan olarak `https://localhost:xxxx` üzerinde açılır (port `launchSettings.json` içinde tanımlıdır).

### Bağlantı Dizesi
`appsettings.json` içinde `DefaultConnection` ile SQLite veritabanı konumu tanımlanır. Varsayılan: proje kökündeki `store.db`.

## Rotalar

| URL | Hedef |
|-----|-------|
| `/` | Ana sayfa |
| `/urunler/{kategoriUrl?}` | Kategoriye göre ürün listesi (örn. `/urunler/telefon`) |
| `/urunler?q=apple` | Arama |
| `/Urun/Details/{id}` | Ürün detay |
| `/Admin` | Admin dashboard |
| `/Kategori` | Kategori yönetimi |
| `/Urun` | Ürün yönetimi (admin) |

## UrunController Endpoint'leri

| Action | HTTP | Açıklama |
|--------|------|----------|
| `Index` | GET | Admin ürün listesi |
| `List(url, q)` | GET | Storefront listeleme + arama |
| `Details(id)` | GET | Ürün detay |
| `Create` | GET/POST | Ürün ekleme (resim upload destekli) |
| `Edit(id)` | GET/POST | Ürün düzenleme |
| `Delete(id)` | POST | Ürün silme |

## Veri Modeli

```
Kategori (1) ───< (N) Urun
```

- `Urun.KategoriId` foreign key
- `Kategori.Uruns` koleksiyon navigation property

Seed verisi `DataContext.OnModelCreating` içinde tanımlıdır: 10 kategori, 3 slider, 8 örnek ürün.

## Yol Haritası

Henüz tamamlanmamış / planlanan parçalar:

- [ ] Authentication & Authorization (Identity)
- [ ] Slider CRUD controller'ı
- [ ] Sepet & Sipariş akışı
- [ ] Kullanıcı yönetimi (Rol bazlı)
- [ ] Kategori Edit / Delete action'ları
- [ ] `[ValidateAntiForgeryToken]` ile CSRF koruması
- [ ] Resim silme (ürün silindiğinde dosya temizliği)
- [ ] Sayfalama (Index ve List ekranları)

## Lisans

Eğitim / kişisel proje. Lisans belirtilmemiştir.
