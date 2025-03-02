using System.Reflection;
using Assignment_1.Models;
using Microsoft.EntityFrameworkCore;
namespace Assignment_1
{
    public class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=CompanyDb2;trusted_connection=true;TrustServerCertificate=true")
                          .UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Topic> topics { get; set; }
        public DbSet<Course_Ins> Course_Ins { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
    }
}
