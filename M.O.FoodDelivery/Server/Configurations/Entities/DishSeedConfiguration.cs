//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using M.O.FoodDelivery.Shared.Domain;

//namespace M.O.FoodDelivery.Server.Configurations.Entities
//{
//    public class DishSeedConfiguration : IEntityTypeConfiguration<Dish>
//    {
//        public void Configure(EntityTypeBuilder<Dish> builder)
//        {
//            builder.HasData(
//                    new Dish
//                    {
//                        Id = 1,
//                        Name = ""
//                        DateCreated = DateTime.Now,
//                        DateUpdated = DateTime.Now,
//                        CreatedBy = "System",
//                        UpdatedBy = "System"
//                    },
//                    new Dish
//                    {
//                        ID = 2,
//                        CusID = 3,
//                        StaffID = 1,
//                        ConDate = DateTime.Now,
//                        ConStartTime = DateTime.Now,
//                        ConEndTime = DateTime.Now.AddHours(+1),
//                        ConFee = 30.50m,
//                        ConDesc = "Eczema Consultation",
//                        DateCreated = DateTime.Now,
//                        DataUpdated = DateTime.Now,
//                        CreatedBy = "Woon",
//                        UpdatedBy = "System"
//                    }
//                    );
//        }
//    }
//}