using System;
using System.Collections.Generic;

namespace M.O.FoodDelivery.DTO
{
    public class DishDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ImageUri { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Options { get; set; }
        public int RestaurantId { get; set; }
        public virtual RestaurantDTO Restaurant { get; set; }
        public List<OrderItemDTO> OrderItems { get; set; }
    }
}