using LeaveApplication.Dal.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApplication.Dal.Configuration
{
    public class JobTitleConfiguration : BaseEntityConfiguration<JobTitle>
    {
        public override void Configure(EntityTypeBuilder<JobTitle> builder)
        {
            base.Configure(builder);

            builder
                .Property(p => p.JobTitleName)
                .IsRequired();

            builder
                .Property(p => p.JobDescription)
                .IsRequired();

            builder
              .HasMany(p => p.Users)
              .WithOne(p => p.JobTitle)
              .HasForeignKey(p => p.JobTitleId);

        }
        
    }
}
