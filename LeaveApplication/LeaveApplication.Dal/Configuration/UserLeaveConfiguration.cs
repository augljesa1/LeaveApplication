using LeaveApplication.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApplication.Dal.Configuration
{
    public class UserLeaveConfiguration : BaseEntityConfiguration<UserLeave>
    {
        public override void Configure(EntityTypeBuilder<UserLeave> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.NotificatonId)
                .IsRequired();

            builder
                .Property(p => p.StartingDate)
                .IsRequired();

            builder
                .Property(p => p.EndingDate)
                .IsRequired();

            builder
                .Property(p => p.IsApproved)
                .IsRequired();

            builder
                .Property(p => p.Approvedby)
                .IsRequired();

            builder
              .HasOne(p => p.Leave)
              .WithMany(p => p.UserLeaves)
              .HasForeignKey(p => p.LeaveId);

        }

    }
}
