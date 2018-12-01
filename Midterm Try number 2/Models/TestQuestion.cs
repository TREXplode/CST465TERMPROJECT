using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class TestQuestion
    {
        public int id { get; set; }
        public string question { get; set; }
        public string type { get; set; }
        public string[] choices { get; set; }
        public virtual string answer { get; set; }
    }
}
