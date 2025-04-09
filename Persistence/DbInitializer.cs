using System.Text.Json;
using Domain.Contracts;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Persistence
{
    public class DbInitializer : IDbInitializer
    {
        private readonly StoreDbContext _context;

        public DbInitializer(StoreDbContext context)
        {
            _context = context;
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
    }
}
