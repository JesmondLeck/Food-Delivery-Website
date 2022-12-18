using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Server.Models
{
    public class OrderItem : BaseDomainModel
    {
        public int OrderQty { get; set; }
        public float Rating { get; set; }
        public int DishId { get; set; }
        public virtual Dish Dish { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
