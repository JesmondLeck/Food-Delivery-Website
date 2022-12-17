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
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Name { get; set; }
        public string ProfileImageUri { get; set; }
        //public string Role { get; set; }
        public string IC { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Restaurant> Restaurants { get; set; }
        public List<Order> Orders { get; set; }
    }
}
