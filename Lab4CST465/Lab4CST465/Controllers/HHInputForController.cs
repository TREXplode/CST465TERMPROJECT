using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab4CST465.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab4CST465.Controllers
{
    public class HHInputForController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ComputerModel());
        }
        [HttpPost]
        public IActionResult Index(ComputerModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return View("Submission", model);
        }
    }
}