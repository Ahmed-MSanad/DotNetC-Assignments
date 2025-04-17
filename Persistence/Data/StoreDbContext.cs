using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options)// the CLR will create an instance of this class and inject the options to it
        { 

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); 
            // instead of this :
            
            // we do so to tell it to read the assembly from the same location that contained the DbContext
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(StoreDbContext).Assembly);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly); // where AssemblyReference is a class in the same assembly
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
