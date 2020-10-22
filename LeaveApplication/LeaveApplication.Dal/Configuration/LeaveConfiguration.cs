using LeaveApplication.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApplication.Dal.Configuration
{
    public class LeaveConfiguration : BaseEntityConfiguration<Leave>
    {
        public override void Configure(EntityTypeBuilder<Leave> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.LeaveType)
                .IsRequired();

            builder
                .Property(p => p.Description)
                .IsRequired();

            builder
              .HasMany(p => p.UserLeaves)
              .WithOne(p => p.Leave)
              .HasForeignKey(p => p.LeaveId);


        }

    }
}