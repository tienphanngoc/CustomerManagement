using CustomerManagement.Data.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.Configurations
{
    public class CarColorConfiguration : IEntityTypeConfiguration<CarColor>()
    {
        public void Configure(EntityTypeBuilder<CarColor> builder)
        {
            builder.ToTable("CarColors");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(30);
            builder.Property(e => e.EnglishName).HasMaxLength(30);
            builder.Property(e => e.HEX).IsRequired().HasMaxLength(6);
            builder.HasOne(e => e.CarCategory).WithMany(c => c.CarColors).HasForeignKey(e => e.CarCategoryId);
        }
    }
}
