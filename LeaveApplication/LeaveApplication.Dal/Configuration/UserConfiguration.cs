using LeaveApplication.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApplication.Dal.Configuration
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder
                .HasOne(p => p.JobTitle)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.JobTitleId);

        } 
    }
}
