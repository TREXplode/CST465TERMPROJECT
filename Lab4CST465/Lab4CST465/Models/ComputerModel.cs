using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4CST465.Models
{
    public class ComputerModel
    {
        public string Name { get; set; }
        public string AdministratorPassword { get; set; }
        public string IPAddress { get; set; }
        public string Location { get; set; }
        public string OS { get; set; }
        public string Description { get; set; }
        public int SupportedMonitors { get; set; }

        public static readonly List<string> OSTypes = new List<string> { "IOS", "Windows", "Linux" };
    }
}
