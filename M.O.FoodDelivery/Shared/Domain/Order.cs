using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Shared.Domain
{
    public class Order : BaseDomainModel
    { 
        public string Status { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
