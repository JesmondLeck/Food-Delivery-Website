using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Shared.Domain
{
    public class User : BaseDomainModel
    {
        public string Name { get; set; }
        public string ProfileImageUri { get; set; }
        public string Role { get; set; }
        public string IC { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Restaurant> Restaurants { get; set; }
        public List<Order> Orders { get; set; }
    }
}
