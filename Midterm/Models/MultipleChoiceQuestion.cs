using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Midterm.Models
{
    public class MultipleChoiceQuestion : TestQuestion
    {
        [Required(ErrorMessage = "You need to answer this Quesiton")]
        public override string Answer { get; set; }
        public string[] Choice { get; set; }
    }
}