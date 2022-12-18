using IdentityServer4.EntityFramework.Options;
using M.O.FoodDelivery.Server.Configurations.Entities;
using M.O.FoodDelivery.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Server.Data
{
    public class ApplicationDbContext : KeyApiAuthorizationDbContext<ApplicationUser, ApplicationRole,
int>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options,
            operationalStoreOptions)
        {
        }
        //Users are stored in AspNet.Users
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RoleSeedConfiguration());
            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
            builder.ApplyConfiguration(new UserSeedConfiguration());
            builder.ApplyConfiguration(new PaymentSeedConfiguration());
            builder.ApplyConfiguration(new OrderSeedConfiguration());
            builder.ApplyConfiguration(new RestaurantSeedConfiguration());
            builder.ApplyConfiguration(new DishSeedConfiguration());
            builder.ApplyConfiguration(new OrderItemSeedConfiguration());
            builder.ApplyConfiguration(new ReviewSeedConfiguration());
        }
    }
}
