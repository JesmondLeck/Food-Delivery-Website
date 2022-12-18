using System;

namespace M.O.FoodDelivery.DTO
{
    public class ReviewDTO
    {
        public int Id { get; set; }
        public bool IsFavorite { get; set; }
        public string Feedback { get; set; }
        public int RestaurantId { get; set; }
        public virtual RestaurantDTO Restaurant { get; set; }
        public int? CustomerId { get; set; }
        public virtual ApplicationUserDTO Customer { get; set; }
    }
}