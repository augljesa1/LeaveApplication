using System;
using System.Collections.Generic;

namespace LeaveApplication.Dal.Models
{
    public class Leave : BaseEntity
    {
        public string LeaveType { get; set; }
        public string Description { get; set; }
        public ICollection<UserLeave> UserLeaves { get; set; }
    }
}
