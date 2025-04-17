
using System.Reflection.Metadata;
using Domain.Contracts;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Data;
using Persistence.Repositories;
using Services;
using Services.Abstraction;
using Services.MappingProfiles;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Store.Api
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<StoreDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultSQLConnection"));
            });

            builder.Services.AddScoped<IDbInitializer, DbInitializer>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            builder.Services.AddScoped<IServiceManager, ServiceManager>();


            //builder.Services.AddAutoMapper(typeof(AssemblyReference).Assembly); // XX Not Working

            //builder.Services.AddAutoMapper(x => x.AddProfile(new ProductProfile())); // XX not general => this is not a good practice, because you are creating a new instance of ProductProfile and not using the one registered in the DI container.
            //You're manually creating an instance of ProductProfile with new ProductProfile(). This means AutoMapper doesn’t go through 
            //the DI container, so any services required by your custom resolvers(like IConfiguration, IHttpContextAccessor, etc.) won’t get injected — causing the error.

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            // or:
            //builder.Services.AddAutoMapper(typeof(Services.ServiceManager).Assembly);



            var app = builder.Build();

            await SeedDbAsync(app);

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }

        static async Task SeedDbAsync(WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
            await dbInitializer.InitializeAsync();
        }
    }
}
