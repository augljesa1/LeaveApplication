using System;
using System.Collections.Generic;

namespace LeaveApplication.Dal.Models
{
    public partial class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public int JobTitleId { get; set; }
        public JobTitle JobTitle { get; set; }
        public ICollection<UserLeave> UserLeave { get; set; }
        public ICollection<UserRole> UserRole { get; set; }
    }
}
