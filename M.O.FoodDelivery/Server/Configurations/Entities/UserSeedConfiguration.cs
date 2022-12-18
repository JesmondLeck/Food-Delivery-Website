using M.O.FoodDelivery.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M.O.FoodDelivery.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                 new ApplicationUser
                 {
                     Id = 1,
                     Name = "Thomas",
                     UserName = "Thomas",
                     NormalizedUserName = "THOMAS",
                     ProfileImageUri = null,
                     //Role = "Owner",
                     IC = "S8774367G",
                     Email = "thomasdoe@gmail.com",
                     NormalizedEmail = "THOMASDOE@GMAIL.COM",
                     Password = "123456",
                     PasswordHash = hasher.HashPassword(null, "123456"),
                     Address = "Tampines North Street 123 Blk 45 #6-759",
                     SecurityStamp = Guid.NewGuid().ToString(),
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System",
                 },
                 new ApplicationUser
                 {
                     Id = 2,
                     Name = "Samantha",
                     UserName = "Samantha",
                     NormalizedUserName = "SAMANTHA",
                     ProfileImageUri = null,
                     //Role = "Customer",
                     IC = "S1234567F",
                     Email = "samlee@gmail.com",
                     NormalizedEmail = "SAMLEE@GMAIL.COM",
                     Password = "abcdef1234",
                     PasswordHash = hasher.HashPassword(null, "abcdef1234"),
                     Address = "113 Bedok North Street #5-102",
                     SecurityStamp = Guid.NewGuid().ToString(),
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
                 );
        }
    }
}
