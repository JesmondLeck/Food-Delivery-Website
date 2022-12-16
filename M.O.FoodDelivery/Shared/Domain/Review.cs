using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Shared.Domain
{
    public class Review : BaseDomainModel
    {
        public Boolean IsFavorite { get; set; }
        public string Feedback { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
