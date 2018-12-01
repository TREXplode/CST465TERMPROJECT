using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab5CST465.Objects;

namespace Lab5CST465.Models
{
    public class TreaterM
    {
        public List<Candy> CandyList;
        public List<Costume> CostumeList;
        public List<Treater> TreaterList;
        public string Name { get; set; }
        public int CandyID { get; set; }
        public int CostumeID { get; set; }
    }
}
