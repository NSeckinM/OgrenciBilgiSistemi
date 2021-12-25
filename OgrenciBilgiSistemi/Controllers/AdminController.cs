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


        public IActionResult CreateOgr()
        {
            CreateOgrViewModel covm = new();
            covm.mufredats = _dbContext.Mufredatlar.ToList();

            return View(covm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOgr(CreateOgrViewModel model)
        {
            if (ModelState.IsValid)
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

                string sifre = model.Ad.ToLower() + "Atlm.22" ;

                var result = await _userManager.CreateAsync(kullanici, sifre);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(kullanici, "ogr");
                }

                _dbContext.SaveChanges();

                return RedirectToAction("Index", "Admin");

            }
            return View();

        }

        // GET: AdminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        // GET: AdminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
