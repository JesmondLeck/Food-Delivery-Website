using M.O.FoodDelivery.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Server.Configurations.Entities
{
    public class DishSeedConfiguration : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder.HasData(
                 new Dish
                 {
                     Id = 1,
                     Name = "Brunch for 2 - Veg",
                     Type = "Punjabi",
                     ImageUri = null,
                     Price = 12.0,
                     Description = "Brunch: One meal to rule them all! Grab this mega saver combo with your choice of 2 veg wraps, Aloo Paratha (2 pcs), chole and Curd lunchbox and 2 choco lava cakes. This is just bliss on a plate!",
                     Options = "NIL",
                     RestaurantId = 1,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Dish
                 {
                     Id = 2,
                     Name = "Royal Chicken Rice Bowl (Jumbo)",
                     Type = "South Indian",
                     ImageUri = null,
                     Price = 12.0,
                     Description = "Juicy chicken mixed with curry and sausages.",
                     Options = "NIL",
                     RestaurantId = 1,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Dish
                 {
                     Id = 3,
                     Name = "Paneer Signature Rice Bowl (Regular)",
                     Type = "South Indian",
                     ImageUri = null,
                     Price = 10.0,
                     Description = null,
                     Options = "NIL",
                     RestaurantId = 2,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
                 );
        }
    }
}
