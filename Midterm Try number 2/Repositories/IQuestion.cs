using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Midterm.Models;

namespace Midterm.Repositories
{
    public interface IQuestion
    {
        List<TestQuestion> GetList();
        void SaveAnswers(List<TestQuestion> test);
    }
}
