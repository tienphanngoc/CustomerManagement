using CustomerManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.EF
{
    public class CRMDbContext : DbContext
    {
        public CRMDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarModelCategory> CarModelCategories { get; set; }
        public DbSet<CarColor> CarColors { get; set; }
        public DbSet<CarEntity> CarEntities { get; set; }
    }
}
