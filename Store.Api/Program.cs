using Domain.Contracts;
using Microsoft.AspNetCore.Mvc;
using Services;
using Services.Abstraction;
using Shared.IdentityDtos;
using Store.Api.Extensions;
using Store.Api.Factories;
using Store.Api.MiddleWares;

namespace Store.Api
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddInfrastructureServices(builder.Configuration);

            builder.Services.AddCoreServices(builder.Configuration);

            builder.Services.AddPresentationServices();


            var app = builder.Build();

            await app.SeedDbAsync();

            app.UseMiddleware<GlobalErrorHandlingMiddleware>();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
