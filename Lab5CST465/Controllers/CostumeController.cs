using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab5CST465.Models;

namespace Lab5CST465.Controllers
{
    public class CostumeController : Controller
    {
        [HttpGet]
        public IActionResult IndexGet()
        {
            return View(new Costume());
        }
        [HttpPost]
        public IActionResult IndexPost(Costume model)
        {
            return View(model);
        }
    }
}