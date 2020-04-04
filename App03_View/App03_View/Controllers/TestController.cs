using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace App03_View.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            TempData["msg"] = "Data from Test Controller";
            return RedirectToAction("privacy", "home");
        }
    }
}