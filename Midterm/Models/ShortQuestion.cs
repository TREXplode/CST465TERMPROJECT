using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Midterm.Models
{
    public class ShortQuestion : TestQuestion
    {
        [Required(ErrorMessage = "You need to answer this Quesiton")]
        [StringLength(100)]
        public override string Answer { get; set; }
    }
}