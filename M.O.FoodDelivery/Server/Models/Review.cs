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

<<<<<<< HEAD:M.O.FoodDelivery/Server/Models/Review.cs
        [ForeignKey("ApplicationUser")]
        public int? CustomerId { get; set; }
        public virtual ApplicationUser Customer { get; set; }
=======
        [ForeignKey("User")]
        public int? CustomerId { get; set; }
        public virtual User User { get; set; }
>>>>>>> e01c4c1acb9a1b9cdd486245a004e5fb44fc983d:M.O.FoodDelivery/Shared/Domain/Review.cs
    }
}
