using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Shared.Domain
{
    public class Restaurant : BaseDomainModel
    { 
        public string Name { get; set; }
        public string ImageUri { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int OwnerId { get; set; }
        public virtual User User { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Dish> Dishes { get; set; }
    }
}
