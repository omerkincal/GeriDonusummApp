using GeriDonusummApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeriDonusummApp.Controllers
{
    public class GeriDonusumController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "Good Afternoon " : "Good Morning";


            return View("MyView");
        }
        public ViewResult List()
        {
            var liste = Repository.Customers.Where(i => i.WillAttend == true);

            return View(liste);
        }

        
    }
}
