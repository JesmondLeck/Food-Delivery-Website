using System;
using System.Collections.Generic;

namespace M.O.FoodDelivery.DTO
{
    public class PaymentDTO
    {
        public int Id { get; set; }
        public DateTime PaidOn { get; set; }
        public string Type { get; set; }
        public List<OrderDTO> Orders { get; set; }
    }
}