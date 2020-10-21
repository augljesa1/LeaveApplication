using System;
using System.Collections.Generic;

namespace LeaveApplication.Dal.Models
{
    public class Leave
    {
        public int LeaveId { get; set; }
        public string LeaveType { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserLeave> UserLeave { get; set; }
    }
}
