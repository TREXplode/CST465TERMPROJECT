using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab5CST465.Objects;

namespace Lab5CST465.Repositories
{
    public interface ICandy
    {
        List<Candy> GetList();
        void Insert(Candy cand);
        void Delete(int cand);
    }
}
