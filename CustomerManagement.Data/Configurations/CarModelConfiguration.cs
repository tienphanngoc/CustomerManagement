using CustomerManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.Configurations
{
    public class CarModelConfiguration : IEntityTypeConfiguration<CarModel>
    {
        public void Configure(EntityTypeBuilder<CarModel> builder)
        {
            builder.ToTable("CarModels");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Engine).IsRequired().HasMaxLength(50);
            builder.Property(e => e.GearBox).IsRequired().HasMaxLength(50);
            builder.Property(e => e.MY).HasDefaultValue(0);
            builder.Property(e => e.YOM).HasDefaultValue(0);
            builder.Property(e => e.OriginalPrice).HasDefaultValue(0);
            builder.Property(e => e.Name).IsRequired().HasMaxLength(50);
            
        }
    }
}
