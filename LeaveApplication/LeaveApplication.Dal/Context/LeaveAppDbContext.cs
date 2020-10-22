using LeaveApplication.Dal.Configuration;
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            const string connectionString = "Server=DESKTOP-9MP6ML1\\SQLEXPRESS;Database=UGI;Trusted_Connection=True";
            /*"ConnectionStrings": {
    "LibraryConnection": "Server=DESKTOP-9MP6ML1\\SQLEXPRESS;Database=Novabaza;Trusted_Connection=True;MultipleActiveResultSets=True"
  },*/
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new JobTitleConfiguration());
            modelBuilder.ApplyConfiguration(new UserLeaveConfiguration());
            modelBuilder.ApplyConfiguration(new LeaveConfiguration());
            modelBuilder.ApplyConfiguration(new NotificationConfiguration());


            base.OnModelCreating(modelBuilder);
        }


    }
}
