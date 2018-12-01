using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Midterm.Models;
using Microsoft.AspNetCore.Mvc;
using Midterm.Repositories;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Midterm.Controllers
{
    public class MidtermController : Controller
    {
        private List<TestQuestion> Test;
        private ITestRepository TestRepo;
        private TestSettings _settings;

        public MidtermController(IOptionsSnapshot<TestSettings> tset, ITestRepository Trepo)
        {
            _settings = tset.Value;
            TestRepo = Trepo;
            Test = new List<TestQuestion>();
        }
        [HttpGet]
        public IActionResult TakeTest()
        {
            return View(GetTestQuestions());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult TakeTest(List<TestQuestion> model)
        {
            foreach(var q in model)
            {
                TestRepo.SaveAnswer(q);
            }
            if (!ModelState.IsValid)
                return View(model);
            model = GetTestQuestions();
            return View("DisplayResults", model);
        }
        public List<TestQuestion> GetTestQuestions()
        {
            Test = TestRepo.GetList();

            return Test;
        }
    }
}