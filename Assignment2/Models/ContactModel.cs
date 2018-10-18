using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class ContactModel
    {
        [Required(ErrorMessage = "Some info is missing!!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Some info is missing!!")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Some info is missing!!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Some info is missing!!")]
        public string Message { get; set; }
    }
}
