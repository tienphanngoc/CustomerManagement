using CustomerManagement.Data.Configurations;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new CarCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CarColorConfiguration());
            modelBuilder.ApplyConfiguration(new CarModelConfiguration());
            modelBuilder.ApplyConfiguration(new CarModelCategoryConfiguration());
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarModelCategory> CarModelCategories { get; set; }
        public DbSet<CarColor> CarColors { get; set; }
        public DbSet<CarEntity> CarEntities { get; set; }

        //Ultities
        public DbSet<SystemActivity> SystemActivities { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        //System
        public DbSet<AppConfig> AppConfigs { get; set; }
    }
}
