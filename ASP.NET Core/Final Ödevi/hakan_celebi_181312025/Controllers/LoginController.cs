using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using hakan_celebi_181312025.Models;
using hakan_celebi_181312025.Models.AppSettingsReader;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using System;

namespace hakan_celebi_181312025.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAppSettingsReaderServices appSettingsReaderServices;
        public LoginController(IAppSettingsReaderServices _appSettingsReaderServices)
        {
            appSettingsReaderServices = _appSettingsReaderServices;
        }

        [HttpGet]
        public IActionResult Index()
        {
            /*if(HttpContext.Request.Cookies["Authority"] != null)
            {
                switch (HttpContext.Request.Cookies["Authority"])
                {
                    case "admin":
                        return Redirect("../Admin/Index");
                    case "system":
                        return Redirect("../System/Index");
                    case "user":
                        return Redirect("../User/Index");
                }
            }*/
            return View();
        }

        [HttpPost]
        public IActionResult Index(User input)
        {
            if (input != null)
            {
                bool sign = false;
                var userList = new List<User>();
                userList.Add(appSettingsReaderServices.user1Section.user);
                userList.Add(appSettingsReaderServices.user2Section.user);
                userList.Add(appSettingsReaderServices.user3Section.user);
                userList.Add(appSettingsReaderServices.user4Section.user);
                userList.Add(appSettingsReaderServices.user5Section.user);
                userList.Add(appSettingsReaderServices.user6Section.user);
                userList.Add(appSettingsReaderServices.user7Section.user);
                userList.Add(appSettingsReaderServices.user8Section.user);
                userList.Add(appSettingsReaderServices.user9Section.user);
                foreach (User item in userList)
                {
                    if (item.Username.Equals(input.Username) && item.Password.Equals(input.Password))
                    {
                        HttpContext.Response.Cookies.Append("Authority", item.Authority.ToString());
                        HttpContext.Response.Cookies.Append("Logged", "true");
                        input.Authority = item.Authority;
                        sign = true;
                        break;
                    }
                }
                if (sign)
                {
                    switch (input.Authority)
                    {
                        case "admin":
                            return Redirect("../Admin/Index");
                        case "system":
                            return Redirect("../System/Index");
                        case "user":
                            return Redirect("../User/Index");
                    }
                }
                else
                    HttpContext.Response.Cookies.Delete("Logged");
            }
            return View();
        }
    }
}
