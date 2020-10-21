using System;
using System.Collections.Generic;

namespace LeaveApplication.Models
{
    public partial class Leave
    {
        public Leave()
        {
            UserLeave = new HashSet<UserLeave>();
        }

        public int LeaveId { get; set; }
        public string LeaveType { get; set; }
        public string Description { get; set; }

        public virtual ICollection<UserLeave> UserLeave { get; set; }
    }
}
