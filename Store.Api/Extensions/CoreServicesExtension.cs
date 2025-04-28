using Services.Abstraction;
using Services;
using Shared.IdentityDtos;

namespace Store.Api.Extensions
{
    public static class CoreServicesExtension
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.Configure<JwtOptions>(configuration.GetSection("JwtOptions"));

            //builder.Services.AddAutoMapper(typeof(AssemblyReference).Assembly); // XX Not Working

            //builder.Services.AddAutoMapper(x => x.AddProfile(new ProductProfile())); // XX not general => this is not a good practice,
            //because you are creating a new instance of ProductProfile and not using the one registered in the DI container.
            //You're manually creating an instance of ProductProfile with new ProductProfile(). This means AutoMapper doesn’t go through 
            //the DI container, so any services required by your custom resolvers(like IConfiguration, IHttpContextAccessor, etc.)
            //won’t get injected — causing the error.

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            // or:
            //builder.Services.AddAutoMapper(typeof(Services.ServiceManager).Assembly);

            return services;
        }
    }
}
