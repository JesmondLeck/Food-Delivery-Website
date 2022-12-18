using System;

namespace M.O.FoodDelivery.DTO
{
    public class OrderItemDTO
    {
        public int Id;
        public int OrderQty { get; set; }
        public float Rating { get; set; }
        public int DishId { get; set; }
        public virtual DishDTO Dish { get; set; }
        public int OrderId { get; set; }
        public virtual OrderDTO Order { get; set; }
    }
}