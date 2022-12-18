using M.O.FoodDelivery.Server.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Server.Models
{
    public class Review : BaseDomainModel
    {
        public bool IsFavorite { get; set; }
        public string Feedback { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }

        [ForeignKey("ApplicationUser")]
        public int? CustomerId { get; set; }
        public virtual ApplicationUser Customer { get; set; }
    }
}
