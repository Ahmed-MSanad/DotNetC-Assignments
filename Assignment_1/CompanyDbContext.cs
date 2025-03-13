using Assignment_1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1
{
    public class CompanyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=CompanyDb;trusted_connection=true;TrustServerCertificate=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Car>().HasBaseType<Vehicle>();
            //modelBuilder.Entity<Truck>().HasBaseType<Vehicle>();

            modelBuilder.Entity<Vehicle>()
                        .HasDiscriminator<string>("VehicleType")
                        .HasValue<Car>("Car")
                        .HasValue<Truck>("Truck");
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Truck> Trucks { get; set; }

    }
}
