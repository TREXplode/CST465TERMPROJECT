using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab8Identity.Models;
using Microsoft.AspNetCore.Authorization;

namespace Lab8Identity.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        Lab8Model mod;
        public HomeController()
        {
            mod = new Lab8Model();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            return View(mod);
        }
        [Authorize]
        [HttpPost]
        public IActionResult Index(Lab8Model tom)
        {
            return View(tom);
        }
    }
}