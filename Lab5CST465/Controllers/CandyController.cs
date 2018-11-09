using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab5CST465.Models;

namespace Lab5CST465.Controllers
{
    public class CandyController : Controller
    {
        [HttpGet]
        public IActionResult IndexGet()
        {
            return View(new Candy());
        }
        [HttpPost]
        public IActionResult IndexPost(Candy model)
        {
            return View(model);
        }
    }
}