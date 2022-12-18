﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Server.Models
{
    public class Dish : BaseDomainModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string ImageUri { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Options { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
