using M.O.FoodDelivery.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Server.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string ProfileImageUri { get; set; }
        //public string Role { get; set; }
        public string IC { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}

