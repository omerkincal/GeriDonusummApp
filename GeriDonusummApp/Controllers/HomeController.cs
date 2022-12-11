using GeriDonusummApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace GeriDonusummApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ViewResult Login()
        {
            return View();
        }
        public IActionResult Index()
        {
            GeriDonusummApp.Models.Requests model = new GeriDonusummApp.Models.Requests();
            model.Name = "Ömer Kıncal";
            model.Email = "omerkincaş@gmail.com";
            model.Phone = 53345465;
            model.Message = "Projemi yapmaya çalışıyorum";

            return View("index" ,model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        

        [HttpPost]
        public ViewResult Login(Customer customer)
        {
            if (ModelState.IsValid)
            {
                Repository.AddCustomer(customer);
                return View("anasayfa", customer);
            }
            else
            {
                return View();
            }
        }

        public ViewResult Register()
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
