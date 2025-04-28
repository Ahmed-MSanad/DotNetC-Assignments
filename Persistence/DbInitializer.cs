using System.Text.Json;
using Domain.Contracts;
using Domain.Entities;
using Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using Persistence.Identity;

namespace Persistence
{
    public class DbInitializer : IDbInitializer
    {
        private readonly StoreDbContext _context;
        private readonly StoreIdentityDbContext _identityDbContext;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;

        public DbInitializer(StoreDbContext context, StoreIdentityDbContext identityDbContext,
                            RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _context = context;
            _identityDbContext = identityDbContext;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task InitializeAsync()
        {
            try
            {
                //if (_context.Database.GetPendingMigrations().Any())
                //    _context.Database.Migrate();
                if (!_context.ProductTypes.Any())
                {
                    var typesData = File.ReadAllText(@"..\Persistence\Data\Seeding\types.json");
                    // types now has string as File.ReadAllText() returns the data in string format.

                    // Serialization & Deserialization:
                    // Serialization: Convert the object into a string or JSON.
                    // Deserialization: Convert the string or JSON into an object.
                    // Deserialize the string into a list of ProductType objects

                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
                    // Why we need to convert to a list of ProductType => as the json file contains an array of objects.
                    // NOTE: the naming of the json properties must match the same name as the columns in the table
                    //      we'll add this data to in the database -> Or error will happen.

                    if (types is not null && types.Any())
                    {
                        await _context.ProductTypes.AddRangeAsync(types);
                        await _context.SaveChangesAsync();
                    }
                }

                if (!_context.ProductBrands.Any())
                {
                    var brandsData = File.ReadAllText(@"..\Persistence\Data\Seeding\brands.json");

                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

                    if (brands is not null && brands.Any())
                    {
                        await _context.ProductBrands.AddRangeAsync(brands);
                        await _context.SaveChangesAsync();
                    }
                }

                if (!_context.Products.Any())
                {
                    var productsData = File.ReadAllText(@"..\Persistence\Data\Seeding\products.json");

                    var products = JsonSerializer.Deserialize<List<Product>>(productsData);

                    if (products is not null && products.Any())
                    {
                        await _context.Products.AddRangeAsync(products);
                        await _context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex) {
                throw;
            }
        }
    
        public async Task InitializeIdentityAsync()
        {
            if (_identityDbContext.Database.GetPendingMigrations().Any())
                await _identityDbContext.Database.MigrateAsync();

            if (!_roleManager.Roles.Any())
            {
                await _roleManager.CreateAsync(new IdentityRole("Admin"));
                await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
            }

            if (!_userManager.Users.Any())
            {
                var adminUser = new User
                {
                    DisplayName = "Admin",
                    Email = "Admin@gmail.com",
                    UserName = "Admin123",
                    PhoneNumber = "1234567890",
                };

                var superAdminUser = new User
                {
                    DisplayName = "super Admin",
                    Email = "superAdmin@gmail.com",
                    UserName = "superAdmin123",
                    PhoneNumber = "1234567890",
                };

                await _userManager.CreateAsync(adminUser, "Passw0rd");
                await _userManager.CreateAsync(superAdminUser, "Passw0rd");

                await _userManager.AddToRoleAsync(adminUser, "Admin");
                await _userManager.AddToRoleAsync(superAdminUser, "SuperAdmin");
            }

        }
    }
}
