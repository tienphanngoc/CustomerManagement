using CustomerManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Data.Configurations
{
    class EmployeePositionConfiguration : IEntityTypeConfiguration<EmployeePosition>
    {
        public void Configure(EntityTypeBuilder<EmployeePosition> builder)
        {
            builder.ToTable("EmployeePositions");
            builder.Property(e => e.Name).HasMaxLength(70);
            builder.HasOne(e => e.Parent).WithMany(e => e.Childs).HasForeignKey(e => e.ParentId);
            builder.Property(e => e.Level).HasDefaultValue(0);
        }
    }
}
