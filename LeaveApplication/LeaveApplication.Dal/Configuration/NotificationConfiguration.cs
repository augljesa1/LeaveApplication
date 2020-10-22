using LeaveApplication.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApplication.Dal.Configuration
{
    public class NotificationConfiguration : BaseEntityConfiguration<Notification>
    {
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.Description)
                .IsRequired();

            builder
                .Property(p => p.DateCreated)
                .IsRequired();

            builder
                .Property(p => p.EmailTo)
                .IsRequired();

            builder
                .Property(p => p.EmailFrom)
                .IsRequired();

            builder
              .HasMany(p => p.UserLeaves)
              .WithOne(p => p.Notificaton)
              .HasForeignKey(p => p.NotificatonId);


        }

    }
}