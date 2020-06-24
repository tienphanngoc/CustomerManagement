using CustomerManagement.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Brand
            modelBuilder.Entity<Brand>().HasData(
                new Brand() {Id = 1, Name="Subaru",Logo="/brands-logo/subaru2019.png" },
                new Brand() {Id = 2, Name = "Mazda", Logo = "/brands-logo/mazda2019.png" }
                );
            //Car Category
            modelBuilder.Entity<CarCategory>().HasData(
                new CarCategory() { Id = 1, BrandId = 1, Name = "Outback" },
                new CarCategory() { Id = 2, BrandId = 1, Name = "Forester" },
                new CarCategory() { Id = 3, BrandId = 1, Name = "XV" },
                new CarCategory() { Id = 4, BrandId = 2, Name = "Mazda 2" },
                new CarCategory() { Id = 5, BrandId = 2, Name = "Mazda 3" },
                new CarCategory() { Id = 6, BrandId = 2, Name = "Mazda 6" },
                new CarCategory() { Id = 7, BrandId = 2, Name = "CX-5" },
                new CarCategory() { Id = 8, BrandId = 2, Name = "BT50" }
                );
            //Car Color
            modelBuilder.Entity<CarColor>().HasData(
                new CarColor() { Id = 1, CarCategoryId = 1, Name = "Vàng cát", EnglishName = "Tungsten", HEX = "FFFFFF" },
                new CarColor() { Id = 2, CarCategoryId = 1, Name = "Đen Huyền Bí", EnglishName = "Crystal Black", HEX = "000000" },
                new CarColor() { Id = 3, CarCategoryId = 1, Name = "Xanh xám", EnglishName = "Gray Blue", HEX = "FFFFFF" }
                );
            modelBuilder.Entity<CarColor>().HasData(
                new CarColor() { Id = 4, CarCategoryId = 2, Name = "Đen Huyền Bí", EnglishName = "Crystal Black", HEX = "FFFFFF" },
                new CarColor() { Id = 5, CarCategoryId = 2, Name = "Trắng Ngọc Trai", EnglishName = "Crystal White Pearl", HEX = "000000" },
                new CarColor() { Id = 6, CarCategoryId = 2, Name = "Xanh dương", EnglishName = "Horizontal Blue Pearl", HEX = "FFFFFF" }
                );
            modelBuilder.Entity<CarColor>().HasData(
                new CarColor() { Id = 7, CarCategoryId = 3, Name = "Vàng cam", EnglishName = "Orange", HEX = "FFFFFF" }
                );
            modelBuilder.Entity<CarColor>().HasData(
                new CarColor() { Id = 8, CarCategoryId = 4, Name = "Đen Huyền Bí", EnglishName = "Crystal Black", HEX = "FFFFFF" },
                new CarColor() { Id = 9, CarCategoryId = 5, Name = "Trắng Ngọc Trai", EnglishName = "Crystal White Pearl", HEX = "000000" },
                new CarColor() { Id = 10, CarCategoryId = 6, Name = "Xanh dương", EnglishName = "Horizontal Blue Pearl", HEX = "FFFFFF" }
                );
            modelBuilder.Entity<CarColor>().HasData(
                new CarColor() { Id = 11, CarCategoryId = 7, Name = "Đen Huyền Bí", EnglishName = "Crystal Black", HEX = "FFFFFF" },
                new CarColor() { Id = 12, CarCategoryId = 8, Name = "Trắng Ngọc Trai", EnglishName = "Crystal White Pearl", HEX = "000000" },
                new CarColor() { Id = 13, CarCategoryId = 8, Name = "Xanh dương", EnglishName = "Horizontal Blue Pearl", HEX = "FFFFFF" }
                );
            //Car Model
            modelBuilder.Entity<CarModel>().HasData(
                new CarModel() { Id = 1, Engine = "Boxer H4 2.5", GearBox = "Lineartronic CVT", Name = "Outback 2.5 ES 2020", MY = 2020, YOM = 2020, OriginalPrice = 1868000000},
                new CarModel() { Id = 2, Engine = "Boxer H4 2.0", GearBox = "Lineartronic CVT", Name = "Forester iL 2020", MY = 2019, YOM = 2020, OriginalPrice = 1128000000 },
                new CarModel() { Id = 3, Engine = "Boxer H4 2.0", GearBox = "Lineartronic CVT", Name = "Forester iS 2020", MY = 2019, YOM = 2020, OriginalPrice = 1218000000 },
                new CarModel() { Id = 4, Engine = "Boxer H4 2.0", GearBox = "Lineartronic CVT", Name = "Forester iS ES 2020", MY = 2020, YOM = 2020, OriginalPrice = 1288000000 },
                new CarModel() { Id = 5, Engine = "Boxer H4 2.0", GearBox = "Lineartronic CVT", Name = "Forester iL 2019", MY = 2019, YOM = 2019, OriginalPrice = 1128000000 },
                new CarModel() { Id = 6, Engine = "Boxer H4 2.0", GearBox = "Lineartronic CVT", Name = "Forester iS 2019", MY = 2019, YOM = 2019, OriginalPrice = 1218000000 },
                new CarModel() { Id = 7, Engine = "Boxer H4 2.0", GearBox = "Lineartronic CVT", Name = "Forester iS ES 2019", MY = 2019, YOM = 2019, OriginalPrice = 1288000000 },
                new CarModel() { Id = 8, Engine = "Boxer H4 2.0", GearBox = "Lineartronic CVT", Name = "XV ES 2019", MY = 2019, YOM = 2019, OriginalPrice = 1516000000 }
                );

            //CarModelCategory
            c.Entity<CarModelCategory>().HasData(
                new CarModelCategory() { CarModelId = 1, CarCategoryId = 1 },
                new CarModelCategory() { CarModelId = 2, CarCategoryId = 2 },
                new CarModelCategory() { CarModelId = 3, CarCategoryId = 2 },
                new CarModelCategory() { CarModelId = 4, CarCategoryId = 2 },
                new CarModelCategory() { CarModelId = 5, CarCategoryId = 2 },
                new CarModelCategory() { CarModelId = 6, CarCategoryId = 2 },
                new CarModelCategory() { CarModelId = 7, CarCategoryId = 2 },
                new CarModelCategory() { CarModelId = 8, CarCategoryId = 3 }

                ); ;

            //Identity
            const int ADMIN_ID = 1;
            // any guid, but nothing is against to use the same one
            const int ROLE_ID = ADMIN_ID;
            modelBuilder.Entity<EmployeePosition>().HasData(new EmployeePosition
            {
                Id = ROLE_ID,
                Name = "Adminstrator",
                NormalizedName = "adminstrator"
            });

            var hasher = new PasswordHasher<Employee>();
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "admin@subarukimson.vn",
                NormalizedEmail = "admin@subarukimson.vn",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abc123!@#"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
