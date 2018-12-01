using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;
using Lab5CST465.Objects;
using Lab5CST465.Repositories;
using Lab5CST465.Models;
using System.IO;

namespace Lab5CST465.Controllers
{
    public class HomeController : Controller
    {
        private ITreater _TreatRepo;
        private ICandy _CandyRepo;
        private ICostume _CostRepo;
        private TreatersSettings _settings;

        public HomeController(ITreater tree, ICandy cand, ICostume cost, IOptions<TreatersSettings> mysettings)
        {
            _settings = mysettings.Value;
            _CostRepo = cost;
            _CandyRepo = cand;
            _TreatRepo = tree;
            //treater = _TreatRepo.GetList();
        }
        [HttpGet]
        public IActionResult Index()
        {
            TreaterM model = new TreaterM();
            ViewBag.settings = _settings;
            model.CandyList = _CandyRepo.GetList();
            model.CostumeList = _CostRepo.GetList();
            model.TreaterList = _TreatRepo.GetList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(TreaterM model)
        {
            if (!ModelState.IsValid)
            {
                model.CandyList = _CandyRepo.GetList();
                model.CostumeList = _CostRepo.GetList();
                model.TreaterList = _TreatRepo.GetList();
                return View(model);
            }
            Treater tre = new Treater();
            tre.Name = model.Name;
            tre.Cost = model.CostumeID;
            tre.FavCand = model.CandyID;
            _TreatRepo.Insert(tre);
            return RedirectToAction("Index");
        }
    }
}