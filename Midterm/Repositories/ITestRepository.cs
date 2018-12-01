using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Midterm.Models;

namespace Midterm.Repositories
{
    public interface ITestRepository
    {
        TestQuestion Get(int id);
        List<TestQuestion> GetList();
        String GetAnswer(TestQuestion question);
        void SaveAnswer(TestQuestion question);
    }
}
