using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab4CST465.Models
{
    public class ComputerModel
    {
        [Required(ErrorMessage = "A Name is a required")]
        [StringLength(20)]
        public string Name { get; set; }
        [Required(ErrorMessage ="A password is required")]
        [DataType(DataType.Password)]
        public string AdministratorPassword { get; set; }
        //[Required(ErrorMessage = "An IP Address is required")]
        [RegularExpression(@"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")]
        public string IPAddress { get; set; }
        //[Required(ErrorMessage = "A Location is required")]
        public string Location { get; set; }
        [Required(ErrorMessage = "An operating system is required")]
        [UIHint("OSDropdown")]
        public string OS { get; set; }
        //[Required(ErrorMessage = "")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Required(ErrorMessage = "The number of supported monitors is required")]
        [Range(1, 4)]
        public int SupportedMonitors { get; set; }

        public static readonly List<string> OSTypes = new List<string> { "IOS", "Windows", "Linux" };
    }
}
