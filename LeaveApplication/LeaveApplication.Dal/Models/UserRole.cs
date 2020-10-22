using System;
using System.Collections.Generic;

namespace LeaveApplication.Dal.Models
{
    public partial class UserRole : BaseEntity
    {
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public User User { get; set; }
    }
}
