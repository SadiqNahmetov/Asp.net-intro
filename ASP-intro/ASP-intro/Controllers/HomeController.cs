using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_intro.Controllers
{
    public class HomeController : Controller
    {
        //public string Index(int id, string name)
        //{
        //    return "Home page" + "-" + id + "-" + name;
        //}

        public IActionResult Index(int id, string name)
        {
            //return Json(new { name = "Seid", surname="Nuraliyev"});
            //return Content("Hello P130!");
            return View();
        }

        public string FullData( string name,string surname, int age)
        {
            return $"Name-{name}; Surname-{surname}-Age-{age}";
        }
    }
}
