using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hafta4.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Hafta4.Controlls
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var news = new List<News>()
            {
                /*new News(){ID=1, Title="Karaman Konya Arası Hız Treni Çalışmaları Hız Kazandı Ocak Da Kullanımda!", Approve=true}
                Listeye sınıf nesnesi ekleme yukarıdaki şekilde de yapılabilirdi.*/
                new News(1, "Karaman Konya Arası Hız Treni Çalışmaları Hız Kazandı Ocak Da Kullanımda!", true),
                new News(2, "Karaman da Doç. Dr. Deniz ÜSTÜN Aracılığı İle Yapay Zeka Labaratuvarı Kuruldu!", false),
                new News(3, "Karaman Türk Dili Festivali Düzenledi!", true),
            };
            return View(news);
        }
    }
}
