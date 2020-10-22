using System;
using System.Collections.Generic;
using System.Text;

namespace LeaveApplication.Dal.Models
{

    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }


            protected BaseEntity()
        {
            CreatedAt = DateTime.UtcNow;
            //CreatedBy = username;
        }

    
        
    }
}
