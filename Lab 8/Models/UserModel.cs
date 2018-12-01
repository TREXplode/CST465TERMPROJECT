using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Lab8Identity.Models
{
    public class UserModel : IdentityUser
    {
        public int NumCows { get; set; }
        public string FavVideoGame { get; set; }
    }
}
