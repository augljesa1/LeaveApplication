﻿using System;
using System.Collections.Generic;

namespace LeaveApplication.Dal.Models
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }
        public DateTime DateAdded { get; set; } 
        public DateTime DateModified { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
