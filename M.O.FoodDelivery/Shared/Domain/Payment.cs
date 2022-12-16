using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public DateTime PaidOn { get; set; }
        public string Type { get; set; }
    }
}
