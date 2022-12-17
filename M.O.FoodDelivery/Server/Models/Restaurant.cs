using M.O.FoodDelivery.Server.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [ForeignKey("ApplicationUser")]
        public int? OwnerId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual List<Review> Reviews { get; set; }
        public virtual List<Dish> Dishes { get; set; }
    }
}
