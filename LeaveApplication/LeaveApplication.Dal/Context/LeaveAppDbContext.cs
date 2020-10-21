using LeaveApplication.Dal.Domain;
using LeaveApplication.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace LeaveApplication.Dal.Context
{
    public class LeaveAppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        //ovdje navedemo sve tabele
        public  DbSet<JobTitle> JobTitle { get; set; }
        public  DbSet<Leave> Leave { get; set; }
        public  DbSet<Notification> Notification { get; set; }
        public  DbSet<Role> Role { get; set; }
        public  DbSet<User> User { get; set; }
        public  DbSet<UserLeave> UserLeave { get; set; }
        public  DbSet<UserRole> UserRole { get; set; }


    }
}
