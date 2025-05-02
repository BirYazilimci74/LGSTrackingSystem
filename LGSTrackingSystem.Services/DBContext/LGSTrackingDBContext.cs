using LGSTrackingSystem.Domain.Models;
using System.Data.Entity;

namespace LGSTrackingSystem.Services
{
    public class LGSTrackingDBContext : DbContext
    {
        public LGSTrackingDBContext() : base("name=LGSTrackingDBContext")
        {
        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
