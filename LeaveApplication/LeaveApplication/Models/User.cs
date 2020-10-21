using System;
using System.Collections.Generic;

namespace LeaveApplication.Models
{
    public partial class User
    {
        public User()
        {
            UserLeave = new HashSet<UserLeave>();
            UserRole = new HashSet<UserRole>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public int? JobTitleId { get; set; }

        public virtual JobTitle JobTitle { get; set; }
        public virtual ICollection<UserLeave> UserLeave { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
