using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Server.Models
{
    public class Payment : BaseDomainModel
    {
        public DateTime PaidOn { get; set; }
        public string Type { get; set; }
        public List<Order> Orders { get; set; }
    }
}
