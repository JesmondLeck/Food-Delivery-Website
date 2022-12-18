using M.O.FoodDelivery.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Server.Configurations.Entities
{
    public class RestaurantSeedConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData(
                 new Restaurant
                 {
                     Id = 1,
                     Name = "LunchBox - Meals, Rice Bowls and Thalis",
                     ImageUri = null,
                     Description = "North Indian, Punjabi",
                     Address = "Tampines Mall #1-123",
                     OwnerId = 1,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Restaurant
                 {
                     Id = 2,
                     Name = "Fasso - Wraps & Bowls",
                     ImageUri = null,
                     Description = "Southern Indian",
                     Address = "Northpoint #2-123",
                     OwnerId = 1,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
                 );
        }
    }
}
