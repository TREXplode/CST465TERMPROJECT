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
    public class CandyController : Controller
    {
        private ICandy candRepo;
        //List<Candy> list;
        public CandyController(ICandy cand)
        {
            candRepo = cand;
            //list = candRepo.GetList();
        }
        public IActionResult Index()
        {
            CandyM model = new CandyM();
            model.CandyList = candRepo.GetList();
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(string CandyIn)
        {
            Candy NewCandy = new Candy();
            NewCandy.name = CandyIn;
            candRepo.Insert(NewCandy);
            return RedirectToAction("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            candRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}