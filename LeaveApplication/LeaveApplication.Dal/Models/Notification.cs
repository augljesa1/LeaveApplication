using System;
using System.Collections.Generic;

namespace LeaveApplication.Dal.Models
{
    public partial class Notification
    {
        public Notification()
        {
            UserLeave = new HashSet<UserLeave>();
        }

        public int NotificationId { get; set; }
        public string Description { get; set; }
        public DateTime? DateCreated { get; set; }
        public string EmailTo { get; set; }
        public string EmailFrom { get; set; }

        public virtual ICollection<UserLeave> UserLeave { get; set; }
    }
}
