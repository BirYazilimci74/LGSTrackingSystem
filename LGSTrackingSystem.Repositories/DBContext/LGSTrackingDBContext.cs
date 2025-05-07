using LGSTrackingSystem.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace LGSTrackingSystem.Repositories
{
    public class LGSTrackingDBContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=DBLGSTracking;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True;");
            }
        }
    }
}
