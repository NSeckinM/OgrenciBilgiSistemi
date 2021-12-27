using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OgrenciBilgiSistemi.Data;
using OgrenciBilgiSistemi.Data.Entities;
using OgrenciBilgiSistemi.Models.OgrenciVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Controllers
{
    [Authorize(Roles = "ogr")]
    public class OgrenciController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public OgrenciController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult EditIletisimBilgileri(int id)
        {
            Kimlik kimlik = _dbContext.Kimlikler.Where(x => x.Id == id).Include(x => x.Iletisim).FirstOrDefault();
            EditIletisimBilgileriViewModel vm = new()
            {
                Id = id,
                Adres = kimlik.Iletisim.Adres,
                Email = kimlik.Iletisim.Email,
                Gsm = kimlik.Iletisim.Gsm,
                Il = kimlik.Iletisim.Il,
                Ilce = kimlik.Iletisim.Ilce
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditIletisimBilgileri(EditIletisimBilgileriViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var kimlik = _dbContext.Kimlikler.Where(x => x.Id == vm.Id).Include(x => x.Iletisim).Include(x => x.Kullanici).FirstOrDefault();

                kimlik.Id = vm.Id;
                kimlik.Iletisim.Adres = vm.Adres;
                kimlik.Iletisim.Il = vm.Il;
                kimlik.Iletisim.Ilce = vm.Ilce;
                kimlik.Iletisim.Email = vm.Email;
                kimlik.Iletisim.Gsm = vm.Gsm;
                kimlik.Kullanici.UserName = vm.Email;
                kimlik.Kullanici.Email = vm.Email;
                kimlik.Kullanici.NormalizedUserName = kimlik.Kullanici.NormalizedEmail = vm.Email.ToUpperInvariant().Trim();


                _dbContext.SaveChanges();
                return RedirectToAction("Index", "Ogrenci");
            }

            return View();
        }



        public ActionResult OgrBilgisi()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            Kullanici ogrs = _dbContext.Users.Where(x => x.Id == userId).Include(k => k.Kimlik).Include(i => i.Kimlik.Iletisim).FirstOrDefault();

            if (ogrs == null)
            {
                return View();
            }
            return View(ogrs);
        }

        // GET: OgrenciController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OgrenciController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

       

        public ActionResult AlinanDersler()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            Kullanici kullanici = _dbContext.Users.Where(x => x.Id == userId).Include(k => k.Kimlik).Include(i => i.Kimlik.Iletisim).FirstOrDefault();
            Ogrenci ogrenci = _dbContext.Ogrenciler.Where(x => x.KimlikId == kullanici.KimlikId).FirstOrDefault();
            List<DersKayit> dersKayitlari = _dbContext.DersKayitlari.Where(x => x.OgrenciId == ogrenci.Id).Include(x => x.Ders).ToList();
            return View(dersKayitlari);
        }


    }
}
