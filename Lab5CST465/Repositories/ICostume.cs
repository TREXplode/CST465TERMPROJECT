using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab5CST465.Objects;

namespace Lab5CST465.Repositories
{
    public interface ICostume
    {
        List<Costume> GetList();
        void Insert(Costume cost);
        void Delete(int cost);
    }
}
