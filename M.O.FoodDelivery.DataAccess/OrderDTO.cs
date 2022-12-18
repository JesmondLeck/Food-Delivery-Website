using System;
using System.Collections.Generic;

namespace M.O.FoodDelivery.DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int UserId { get; set; }
        public virtual ApplicationUserDTO User { get; set; }
        public int PaymentId { get; set; }
        public virtual PaymentDTO Payment { get; set; }
        public List<OrderItemDTO> OrderItems { get; set; }
    }
}