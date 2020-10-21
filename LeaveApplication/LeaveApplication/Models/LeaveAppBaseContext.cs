using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LeaveApplication.Models
{
    public partial class LeaveAppBaseContext : DbContext
    {
        public LeaveAppBaseContext()
        {
        }

        public LeaveAppBaseContext(DbContextOptions<LeaveAppBaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<JobTitle> JobTitle { get; set; }
        public virtual DbSet<Leave> Leave { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserLeave> UserLeave { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-9MP6ML1\\SQLEXPRESS;Database=LeaveAppBase;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobTitle>(entity =>
            {
                entity.Property(e => e.JobTitleId)
                    .HasColumnName("Job_TitleID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Leave>(entity =>
            {
                entity.Property(e => e.LeaveId)
                    .HasColumnName("LeaveID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.Property(e => e.NotificationId)
                    .HasColumnName("NotificationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateCreated).HasColumnType("date");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateAdded).HasColumnType("date");

                entity.Property(e => e.DateModified).HasColumnType("date");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.JobTitleId).HasColumnName("Job_titleID");

                entity.HasOne(d => d.JobTitle)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.JobTitleId)
                    .HasConstraintName("FK_User_JobTitle");
            });

            modelBuilder.Entity<UserLeave>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsApproved).HasColumnName("isApproved");

                entity.Property(e => e.LeaveId).HasColumnName("LeaveID");

                entity.Property(e => e.NotificatonId).HasColumnName("NotificatonID");

                entity.HasOne(d => d.Leave)
                    .WithMany(p => p.UserLeave)
                    .HasForeignKey(d => d.LeaveId)
                    .HasConstraintName("FK_UserLeave_Leave");

                entity.HasOne(d => d.LeaveNavigation)
                    .WithMany(p => p.UserLeave)
                    .HasForeignKey(d => d.LeaveId)
                    .HasConstraintName("FK_UserLeave_User");

                entity.HasOne(d => d.Notificaton)
                    .WithMany(p => p.UserLeave)
                    .HasForeignKey(d => d.NotificatonId)
                    .HasConstraintName("FK_UserLeave_Notification");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRole_User");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
