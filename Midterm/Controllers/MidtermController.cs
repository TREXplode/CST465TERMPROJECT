using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Midterm.Models;
using Microsoft.AspNetCore.Mvc;


namespace Midterm
{
    public class MidtermController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TakeTest()
        {
            return View(new List<TestQuestion>());
        }
        [HttpPost]
        public IActionResult TakeTest(List<TestQuestion> model)
        {
            if(!ModelState.IsValid)
                return View(model);
            return View("DisplayResults", model);
        }
    }
}