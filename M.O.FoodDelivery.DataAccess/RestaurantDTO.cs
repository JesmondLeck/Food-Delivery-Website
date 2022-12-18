using System;
using System.Collections.Generic;

namespace M.O.FoodDelivery.DTO
{
    public class RestaurantDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUri { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int? OwnerId { get; set; }
        public virtual ApplicationUserDTO Owner { get; set; }
        public virtual List<ReviewDTO> Reviews { get; set; }
        public virtual List<DishDTO> Dishes { get; set; }
    }
}