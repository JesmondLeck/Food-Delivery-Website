//using M.O.FoodDelivery.Shared.Domain;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace M.O.FoodDelivery.Server.Configurations.Entities
//{
//    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
//    {
//        public void Configure(EntityTypeBuilder<User> builder)
//        {
//            builder.HasData(
//                new User
//                {
//                    Id = 1,
//                    Name = "Thomas Doe",
//                    ProfileImageUri = null,
//                    IC = "S8774367G",
//                    Email = "thomasdoe@gmail.com",
//                    Password = "123456",
//                    Address = "Tampines North Street 123 Blk 45 #6-759",
//                    DateCreated = DateTime.Now,
//                    DateUpdated = DateTime.Now,
//                    CreatedBy = "System",
//                    UpdatedBy = "System"
//                },
//                 new User
//                 {
//                     Id = 2,
//                     Name = "Tan Yi Hua",
//                     ProfileImageUri = null,
//                     IC = "T0211233I",
//                     Email = "officalyihua@gmail.com",
//                     Password = "123456",
//                     Address = "Yishun 123 Blk 45 #6-759",
//                     DateCreated = DateTime.Now,
//                     DateUpdated = DateTime.Now,
//                     CreatedBy = "System",
//                     UpdatedBy = "System"
//                 }
//            );
//        }
//    }
//}
