using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hafta3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hafta3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetStudents()
        {
            var studentList = new List<ModelsLists>() 
            { 
                new ModelsLists(1, "181312025", "Hakan ÇELEBİ", "Karamanoğlu Mehmetbey Üniversitesi", "Sivas"), 
                new ModelsLists(2, "201312022", "Abdullah ALTUNKAYNAK", "Karamanoğlu Mehmetbey Üniversitesi" ,"Konya"),
                new ModelsLists(3, "null", "Halil Emre BALABAN", "Preparing For University Exam" , "Karaman"),
                new ModelsLists(4, "null", "Furkan YAVUZASLAN", "Preparing For University Exam", "Konya")
            };
            return View(studentList);
        }
    }
}
