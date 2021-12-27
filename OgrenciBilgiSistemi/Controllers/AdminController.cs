using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OgrenciBilgiSistemi.Data;
using OgrenciBilgiSistemi.Data.Entities;
using OgrenciBilgiSistemi.Models.AdminVM;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<Kullanici> _userManager;

        public AdminController(ApplicationDbContext dbContext, UserManager<Kullanici> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        // GET: AdminController 
        public ActionResult Index()
        {

            List<Ogrenci> ogrs = _dbContext.Ogrenciler.Include(k => k.Kimlik).Include(i => i.Kimlik.Iletisim).ToList();

            if (ogrs == null)
            {
                return View();
            }
            return View(ogrs);
        }
        public IActionResult OgrDersGoruntule(int id)
        {
            Ogrenci ogr = _dbContext.Ogrenciler.Include(k => k.Mufredat).Include(k => k.Kimlik).Include(i => i.DersKayitlari).Where(x => x.Id == id).FirstOrDefault();

            List<DersKayit> gelendersler = _dbContext.DersKayitlari.Where(x => x.OgrenciId == id).Include(x => x.Ders).ToList();
            OgrDersGoruntuleViewModel vm = new()
            {
                OgrenciNo = ogr.OgrenciNo,
                Ad = ogr.Kimlik.Ad,
                Soyad = ogr.Kimlik.Soyad,
                MufredatAdi = ogr.Mufredat.MufredatAdi,
                Dersler = gelendersler

            };
            if (vm == null)
            {
                return View();
            }
            return View(vm);
        }


        public IActionResult CreateOgr()
        {
            CreateOgrViewModel vm = new();
            vm.mufredats = _dbContext.Mufredatlar.ToList();

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOgr(CreateOgrViewModel model)
        {
            Iletisim ıletisim = new()
            {
                Adres = model.Adres,
                Il = model.Il,
                Ilce = model.Ilce,
                Email = model.Email,
                Gsm = model.Gsm
            };
            _dbContext.Iletisimler.Add(ıletisim);

            Kimlik kimlik = new()
            {
                TcNo = model.TcNo,
                Ad = model.Ad,
                Soyad = model.Soyad,
                DogumYeri = model.DogumYeri,
                DogumTarihi = model.DogumTarihi,
                Iletisim = ıletisim
            };
            _dbContext.Kimlikler.Add(kimlik);

            Mufredat mufredat = _dbContext.Mufredatlar.FirstOrDefault(x => x.MufredatAdi == model.MufredatAdi);

            Ogrenci ogrenci = new()
            {
                OgrenciNo = model.OgrenciNo,
                Kimlik = kimlik,
                Mufredat = mufredat
            };
            _dbContext.Ogrenciler.Add(ogrenci);
            _dbContext.SaveChanges();

            Kullanici kullanici = new Kullanici()
            {
                KullaniciAdi = model.Ad.ToLower() + "." + model.Soyad.ToLower(),
                Kimlik = kimlik,
                Tur = true,
                UserName = model.Email,
                Email = model.Email,
                EmailConfirmed = true
            };

            string sifre = model.Ad.ToLower() + "Atlm.22";

            var result = await _userManager.CreateAsync(kullanici, sifre);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(kullanici, "ogr");

                _dbContext.SaveChanges();

                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return BadRequest();
            }

        }



        public ActionResult EditOgr(int id)
        {
            Ogrenci ogr = _dbContext.Ogrenciler.Where(x => x.Id == id).Include(k => k.Kimlik).Include(i => i.Kimlik.Iletisim).FirstOrDefault();
            if (ogr == null)
            {
                return NotFound("Sistemde Böyle Bir Öğrenci Bulunamadı.");
            }

            DuzenleOgrViewModel vm = new();
            vm.Id = ogr.Id;
            vm.TcNo = ogr.Kimlik.TcNo;
            vm.Ad = ogr.Kimlik.Ad;
            vm.Soyad = ogr.Kimlik.Soyad;
            vm.DogumYeri = ogr.Kimlik.DogumYeri;
            vm.DogumTarihi = ogr.Kimlik.DogumTarihi;
            vm.Adres = ogr.Kimlik.Iletisim.Adres;
            vm.Il = ogr.Kimlik.Iletisim.Il;
            vm.Ilce = ogr.Kimlik.Iletisim.Ilce;
            vm.Email = ogr.Kimlik.Iletisim.Email;
            vm.Gsm = ogr.Kimlik.Iletisim.Gsm;
            return View(vm);
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditOgr(DuzenleOgrViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Ogrenci ogr = _dbContext.Ogrenciler.Where(x => x.Id == vm.Id).Include(k => k.Kimlik).Include(i => i.Kimlik.Iletisim).Include(i => i.Kimlik.Kullanici).FirstOrDefault();
                ogr.Id = vm.Id;
                ogr.Kimlik.TcNo = vm.TcNo;
                ogr.Kimlik.Ad = vm.Ad;
                ogr.Kimlik.Soyad = vm.Soyad;
                ogr.Kimlik.DogumYeri = vm.DogumYeri;
                ogr.Kimlik.DogumTarihi = vm.DogumTarihi;
                ogr.Kimlik.Iletisim.Adres = vm.Adres;
                ogr.Kimlik.Iletisim.Il = vm.Il;
                ogr.Kimlik.Iletisim.Ilce = vm.Ilce;
                ogr.Kimlik.Iletisim.Email = vm.Email;
                ogr.Kimlik.Iletisim.Gsm = vm.Gsm;
                ogr.Kimlik.Kullanici.KullaniciAdi = vm.Ad.ToLower() + "." + vm.Soyad.ToLower();
                ogr.Kimlik.Kullanici.UserName = vm.Email;
                ogr.Kimlik.Kullanici.Email = vm.Email;
                ogr.Kimlik.Kullanici.NormalizedUserName = ogr.Kimlik.Kullanici.NormalizedEmail = vm.Email.ToUpper().Trim();


                _dbContext.SaveChanges();
                return RedirectToAction("Index", "Admin");

            }

            return View();
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult IndexMufredat()
        {
            List<Mufredat> muf = _dbContext.Mufredatlar.ToList();

            if (muf == null)
            {
                return View();
            }
            return View(muf);

        }

        public IActionResult CreateMuf()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateMuf(CreateMufViewModel model)
        {
            if (ModelState.IsValid)
            {
                Mufredat mufredat = new()
                {
                    MufredatAdi = model.MufredatAdi
                };
                _dbContext.Mufredatlar.Add(mufredat);
                _dbContext.SaveChanges();
                return RedirectToAction("IndexMufredat", "Admin");
            }

            return View();

        }



        public ActionResult EditMuf(int id)
        {
            Mufredat muf = _dbContext.Mufredatlar.Where(x => x.Id == id).FirstOrDefault();
            if (muf == null)
            {
                return NotFound("Sistemde Böyle Bir Müfredat Bulunamadı.");
            }

            DuzenleMufViewModel vm = new();
            vm.Id = muf.Id;
            vm.MufredatAdi = muf.MufredatAdi;
            return View(vm);
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditMuf(DuzenleMufViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Mufredat muf = _dbContext.Mufredatlar.Where(x => x.Id == vm.Id).FirstOrDefault();
                muf.Id = vm.Id;
                muf.MufredatAdi = vm.MufredatAdi;
                _dbContext.SaveChanges();
                return RedirectToAction("IndexMufredat", "Admin");
            }
            return View();
        }



        public ActionResult AtaGuncelleMuf(int id)
        {
            AtaGuncelleMufViewModel vm = new();
            vm.Id = id;
            vm.mufredatlar = _dbContext.Mufredatlar.ToList();
            if (vm.mufredatlar.Count == 0 || vm.Id == 0)
            {
                return NotFound();
            }
            return View(vm);
        }

        [HttpPost]
        public ActionResult AtaGuncelleMuf(AtaGuncelleMufViewModel vm)
        {
            if (vm.Id != 0)
            {
                Ogrenci ogrenci = _dbContext.Ogrenciler.Where(x => x.Id == vm.Id).FirstOrDefault();
                Mufredat mufredat = _dbContext.Mufredatlar.Where(x => x.MufredatAdi == vm.muf).FirstOrDefault();
                ogrenci.Mufredat = mufredat;

                _dbContext.SaveChanges();
               return RedirectToAction("Index", "Admin");
            }
            return View();
           
        }



        public ActionResult IndexDers()
        {
            List<Ders> dersler = _dbContext.Dersler.ToList();

            if (dersler == null)
            {
                return View();
            }
            return View(dersler);

        }


        public IActionResult CreateDers()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateDers(CreateDersViewModel model)
        {
            if (ModelState.IsValid)
            {
                Ders ders = new()
                {
                    DersKodu = model.DersKodu,
                    DersAdi = model.DersAdi,
                    Durum = model.Durum,
                    Kredi = model.Kredi
                };
                _dbContext.Dersler.Add(ders);
                _dbContext.SaveChanges();
                return RedirectToAction("IndexDers", "Admin");
            }

            return View();

        }

        public ActionResult EditDers(int id)
        {
            Ders ders = _dbContext.Dersler.Where(x => x.Id == id).FirstOrDefault();
            if (ders == null)
            {
                return NotFound("Sistemde Böyle Bir Ders Bulunamadı.");
            }

            DuzenleDersViewModel vm = new();
            vm.Id = ders.Id;
            vm.DersKodu = ders.DersKodu;
            vm.DersAdi = ders.DersAdi;
            vm.Durum = ders.Durum;
            vm.Kredi = ders.Kredi;
            return View(vm);
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditDers(DuzenleDersViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Ders ders = _dbContext.Dersler.Where(x => x.Id == vm.Id).FirstOrDefault();
                ders.Id = vm.Id;
                ders.DersKodu = vm.DersKodu;
                ders.DersAdi = vm.DersAdi;
                ders.Durum = vm.Durum;
                ders.Kredi = vm.Kredi;
                _dbContext.SaveChanges();
                return RedirectToAction("IndexDers", "Admin");
            }
            return View();
        }


    }
}
