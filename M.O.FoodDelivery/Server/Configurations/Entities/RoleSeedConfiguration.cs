using M.O.FoodDelivery.Server.Models;
using M.O.FoodDelivery.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<ApplicationRole>
    {
        public void Configure(EntityTypeBuilder<ApplicationRole> builder)
        {
            builder.HasData(
                 new ApplicationRole
                 {
                     Id = 1,
                     Name = "Owner",
                     NormalizedName = "OWNER"
                 },
                 new ApplicationRole
                 {
                     Id = 2,
                     Name = "Customer",
                     NormalizedName = "CUSTOMER"
                 }
           );
        }
    }
}
