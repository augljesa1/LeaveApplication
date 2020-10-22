using System;
using System.Collections.Generic;

namespace LeaveApplication.Dal.Models
{
    public partial class UserLeave : BaseEntity
    {
        public int LeaveId { get; set; }
        public int NotificatonId { get; set; }
        public string StartingDate { get; set; }
        public string EndingDate { get; set; }
        public bool IsApproved { get; set; }
        public string Approvedby { get; set; }
        public Leave Leave { get; set; }
        public User LeaveNavigation { get; set; }
        public Notification Notificaton { get; set; }
    }
}
