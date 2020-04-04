using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using App03_View.Models;

namespace App03_View.Controllers
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
            return View();
        }

        public IActionResult Course()
        {
            ViewBag.title = "ASP.NET Core MVC Web Application";
            ViewBag.c1 = "C# Programming";
            //ViewBag.sql = "MS SQL Server Database";
            ViewData["sql"] = "MS SQL Server Database";

            string[] courselist = {"C Programming", "C++ Programming", "C# Programming", "objective-C Programming", "JavaScript", "JAVA Programming", "Python Programming"  };
            ViewBag.cl = courselist;

            string c = "ASP.NET Core MVC Web Application";

            //c.ToUpper();

            ViewData["cl"] = courselist;

            return View();
        }

        public IActionResult subjects()
        {
            List<Subject> sublist = new List<Subject>()
            {
                new Subject{Id=1, Name="ASP.NET Core MVC", CreditHour=4},
                new Subject{Id=2, Name="Digital Electronics", CreditHour=3},
                new Subject{Id=3, Name="Business Mathematics", CreditHour=2},
                new Subject{Id=4, Name="Administration", CreditHour=4},
                new Subject{Id=5, Name="Management", CreditHour=2},
                new Subject{Id=6, Name="Social Studies", CreditHour=3}
            };

            ViewBag.slist = sublist;

            return View();
        }

        public IActionResult Privacy()
        {
            ViewBag.m = TempData["msg"];
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
