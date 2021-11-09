using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using _181312025_Hakan.ÇELEBİ.Entities;
using _181312025_Hakan.ÇELEBİ.Models;
using Microsoft.AspNetCore.Mvc;

namespace _181312025_Hakan.ÇELEBİ.Controllers
{
    public class HomeController : Controller
    {
        public EntityViewModel result = new EntityViewModel();

        protected void initializeHeadPhone()
        {
            CultureInfo ci = CultureInfo.InvariantCulture;
            result.headPhones = new List<HeadPhone>()
            {
                new HeadPhone(1, "Apple", "Air Pods", "White", true, 388.90, "2017"),
                new HeadPhone(2, "Xiaomi", "Hybrid Pro", "Black", false, 189.99, "2018"),
                new HeadPhone(3, "Xiaomi", "Piston Basic", "Gold", false, 82.90, "2020"),
                new HeadPhone(4, "JBL", "T205", "Black", true, 165, "2016"),
                new HeadPhone(5, "JBL", "T180A", "Silver", true, 600, "2018"),
                new HeadPhone(6, "Samsung", "Level U", "Blue", true, 257, "2013"),
                new HeadPhone(7, "Sony", "MX150", "Gold", false, 400, "2015"),
                new HeadPhone(8, "Logitech", "G635", "Blue-Black", false, 1834.59, "2019"),
                new HeadPhone(9, "Logitech", "Astro A10", "Green", false, 469, "2020"),
                new HeadPhone(10, "Rampage", "Miracle X4", "RBG", false, 209.99, "2019"),
            };
            result.EntityTypeName = "Kulaklık";
        }

        public HomeController()
        {
            initializeHeadPhone();
        }
        public IActionResult Index()
        {
            return View(result);
        }

        public IActionResult dateNewToOld()
        {
            return View(result);
        }

        public IActionResult dateOldToNew()
        {
            return View(result);
        }

        public IActionResult priceHighToLow()
        {
            return View(result);
        }

        public IActionResult priceLowToHigh()
        {
            return View(result);
        }

        public IActionResult CommentPage()
        {
            return View();
        }
    }
}
