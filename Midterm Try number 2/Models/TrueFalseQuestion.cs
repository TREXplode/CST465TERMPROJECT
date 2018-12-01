using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Midterm.Models
{
    public class TrueFalseQuestion : TestQuestion
    {
        [Required(ErrorMessage = "You need to answer this Quesiton")]
        [UIHint("OSDropdown")]
        public override string answer { get; set; }
        public static readonly List<string> AnswerType = new List<string> { "False", "True" };
    }
}