﻿using System;
using System.Collections.Generic;

namespace LeaveApplication.Models
{
    public partial class JobTitle
    {
        public JobTitle()
        {
            User = new HashSet<User>();
        }

        public int JobTitleId { get; set; }
        public string JobTitleName { get; set; }
        public string JobDescription { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
