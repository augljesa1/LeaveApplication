using System;
using System.Collections.Generic;

namespace LeaveApplication.Dal.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public string JobTitleName { get; set; }
        public string JobDescription { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
