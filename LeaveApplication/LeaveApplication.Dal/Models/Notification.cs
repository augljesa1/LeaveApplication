using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace LeaveApplication.Dal.Models
{
    public class Notification : BaseEntity
    {
        public string Description { get; set; }
        public DateTime? DateCreated { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }
        public ICollection<UserLeave> UserLeaves { get; set; }
    }
}
