using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab4CST465.Controllers
{
    public class HHInputForController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}