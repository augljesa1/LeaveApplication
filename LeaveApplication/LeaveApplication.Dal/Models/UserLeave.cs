using System;
using System.Collections.Generic;

namespace LeaveApplication.Dal.Models
{
    public partial class UserLeave
    {
        public int UserId { get; set; }
        public int? LeaveId { get; set; }
        public int? NotificatonId { get; set; }
        public string StartingDate { get; set; }
        public string EndingDate { get; set; }
        public bool IsApproved { get; set; }
        public string Approvedby { get; set; }

        public virtual Leave Leave { get; set; }
        public virtual User LeaveNavigation { get; set; }
        public virtual Notification Notificaton { get; set; }
    }
}
