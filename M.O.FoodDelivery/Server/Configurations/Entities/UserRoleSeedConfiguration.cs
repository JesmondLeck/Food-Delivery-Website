using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<int>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<int>> builder)
        {
            builder.HasData(
                 new IdentityUserRole<int>
                 {
                     RoleId = 1,
                     UserId = 1
                 },
                 new IdentityUserRole<int>
                 {
                     RoleId = 2,
                     UserId = 2
                 }
            );
        }
    }
}
