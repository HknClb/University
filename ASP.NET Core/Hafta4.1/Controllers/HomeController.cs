using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Hafta4._1.Entities;
using Hafta4._1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Hafta4._1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var result = new EntityViewModel();
            result.news = new List<News>()
            {
                new News(1, "Karaman Konya Arası Hız Treni Çalışmaları Hız Kazandı Ocak Da Kullanımda!", true),
                new News(2, "Karaman da Doç. Dr. Deniz ÜSTÜN Aracılığı İle Yapay Zeka Labaratuvarı Kuruldu!", false),
                new News(3, "Karaman Türk Dili Festivali Düzenledi!", true),
            };
            result.video = new List<Video>()
            {
                new Video(1, "Karaman Türk Dili Festivali Görüntüleri!", "Sosyal", true),
                new Video(2, "Karaman Yapay Zeka Labaratuvarı Görüntüleri!", "Teknoloji", false),
                new Video(3, "Karaman Konya Arası Hızlı Treni Cumhurbaşkanı Kullandı!", "Siyasi", true),
            };
            result.EntityTypeName = "News-Video";
            return View(result);
        }
    }
}
