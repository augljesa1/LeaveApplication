using System;
using System.Collections.Generic;

namespace LeaveApplication.Dal.Models
{
    public class JobTitle : BaseEntity
    {
        public string JobTitleName { get; set; }
        public string JobDescription { get; set; }
        public ICollection<User> Users { get; set; }
        
    }
}

