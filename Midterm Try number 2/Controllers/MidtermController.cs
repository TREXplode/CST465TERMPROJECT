using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Midterm.Models;
using Midterm.Repositories;

namespace Midterm.Controllers
{
    public class MidtermController : Controller
    {
        IQuestion _QuestionRepo;
        MidtermQs mid;
        public MidtermController(IQuestion quest)
        {
            _QuestionRepo = quest;
            mid = new MidtermQs();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult TakeTest()
        {
            mid.Tquestions = _QuestionRepo.GetList();
            return View(mid);
        }
        [HttpPost]
        public IActionResult TakeTest(MidtermQs test)
        {
            if(!ModelState.IsValid)
            {
                mid.Tquestions = _QuestionRepo.GetList();
                return View(mid);
            }
            _QuestionRepo.SaveAnswers(test.Tquestions);
            //mid.Tquestions = _QuestionRepo.GetList();
            return RedirectToAction("DisplayResults");
        }
        [HttpGet]
        public IActionResult DisplayResults()
        {
            mid.Tquestions = _QuestionRepo.GetList();
            return View(mid);
        }
    }
}