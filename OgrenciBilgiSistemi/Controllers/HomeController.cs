using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OgrenciBilgiSistemi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return View("IndexPublic");
            }

            string userEmail = User.FindFirst(ClaimTypes.Email).Value;
            string userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (User.Identity.IsAuthenticated && userEmail == "mno@xyz.com")
            {
                return RedirectToAction("Index", "Admin");

                
            }
            else
            {
                return RedirectToAction("Index", "Ogrenci");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
