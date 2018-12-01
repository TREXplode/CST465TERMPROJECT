using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab5CST465.Repositories;
using Lab5CST465.Objects;
using Lab5CST465.Models;

namespace Lab5CST465.Controllers
{
    public class CostumeController : Controller
    {
        private ICostume CostRepo;
        
        
        public CostumeController(ICostume costume)
        {
            CostRepo = costume;
            //list = CostRepo.GetList();
        }

        public IActionResult Index()
        {
            CostumeM model = new CostumeM();
            model.CostList = CostRepo.GetList();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(string CostumeIn)
        {
            Costume NewCostume = new Costume();
            NewCostume.name = CostumeIn;
            CostRepo.Insert(NewCostume);
            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            CostRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}