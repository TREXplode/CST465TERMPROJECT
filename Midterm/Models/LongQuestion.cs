using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Midterm
{
    public class LongQuestion : TestQuestion
    {
        [Required(ErrorMessage = "You need to answer this Quesiton")]
        public override string Answer { get; set; }
    }
}
