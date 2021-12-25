using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Controllers
{
    [Authorize(Roles = "ogr")]
    public class OgrenciController : Controller
    {
        // GET: OgrenciController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OgrenciController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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

        // GET: OgrenciController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OgrenciController/Edit/5
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

        // GET: OgrenciController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OgrenciController/Delete/5
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
