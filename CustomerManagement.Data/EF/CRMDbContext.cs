using CustomerManagement.Data.Configurations;
using CustomerManagement.Data.Entities;
using CustomerManagement.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.EF
{
    public class CRMDbContext : IdentityDbContext<Employee,EmployeePosition,int>
    {
        public CRMDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurations
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new CarCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CarColorConfiguration());
            modelBuilder.ApplyConfiguration(new CarModelConfiguration());
            modelBuilder.ApplyConfiguration(new CarModelCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeePositionConfiguration());
            
            //Identity Config

            modelBuilder.Entity<IdentityUserClaim<int>>().ToTable("EmployeeClaims");
            modelBuilder.Entity<IdentityUserRole<int>>().ToTable("EmployeePositionEmployees").HasKey(e => new { e.UserId, e.RoleId });
            modelBuilder.Entity<IdentityUserLogin<int>>().ToTable("EmployeeLogins").HasKey(e=>e.UserId);
            modelBuilder.Entity<IdentityRoleClaim<int>>().ToTable("EmployeePositionClaims").HasKey(e=>e.Id);
            modelBuilder.Entity<IdentityUserToken<int>>().ToTable("EmployeeTokens").HasKey(e=>e.UserId);

            //Data Seeding
            modelBuilder.Seed();
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarCategory> CarCategories { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<CarModelCategory> CarModelCategories { get; set; }
        public DbSet<CarColor> CarColors { get; set; }
        public DbSet<CarEntity> CarEntities { get; set; }
        //Identity
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeePosition> EmployeePositions { get; set; }
        //Ultities
        public DbSet<SystemActivity> SystemActivities { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        //System
        public DbSet<AppConfig> AppConfigs { get; set; }
    }
}
