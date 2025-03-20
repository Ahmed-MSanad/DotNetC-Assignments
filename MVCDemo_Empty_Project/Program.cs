using System.Net;
using Microsoft.AspNetCore.Http;

namespace MVCDemo_Empty_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //builder.Services.AddControllers();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!"); // https://localhost:7216
            //app.MapGet("/Home", () => "Hello World!"); // https://localhost:7216/Home

            app.UseRouting();

            #region app.Use

            //app.Use(async (context, next) =>
            //{
            //    Endpoint endpoint = context.GetEndpoint();
            //    if(endpoint == null)
            //    {
            //        await context.Response.WriteAsync("Your Request Page is not found !!");
            //    }
            //    await next();
            //});

            #endregion

            #region app.UseEndpoints() -- app.Run()

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello, World");
            //    });

            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello, Home");
            //    });

            //    // a parameter with routing -> mandatory
            //    endpoints.MapGet("/Products/{id}", async httpContext =>
            //    {
            //        int id = Convert.ToInt32(httpContext.Request.RouteValues["id"]);

            //        await httpContext.Response.WriteAsync($"This product id is => {id}");
            //    });

            //    // multiple parameters with routing -> mandatory
            //    endpoints.MapGet("/Books/{id}/{author}", async httpContext =>
            //    {
            //        var id = httpContext.Request.RouteValues["id"];
            //        string author = httpContext.Request.RouteValues["author"].ToString();
            //        await httpContext.Response.WriteAsync($"Book with => {id}, author is {author}");
            //    });

            //    // optional parameters with routing
            //    endpoints.MapGet("/Customers/{id?}", async httpContext =>
            //    {
            //        var idData = httpContext.Request.RouteValues["id"];

            //        if(idData is not null && int.TryParse(idData.ToString(), out int id))
            //        {
            //            await httpContext.Response.WriteAsync($"This Customer id is => {id}");
            //        }
            //        else
            //        {
            //            await httpContext.Response.WriteAsync("Customer id is not found !!");
            //        }

            //    });

            //    // constraints with routing parameters -> int, alpha, minlength, maxlength, ....
            //    endpoints.MapGet("/Order/{id:int}/{owner:alpha:minlength(3):maxlength(15)}", async httpContext =>
            //    {
            //        int id = Convert.ToInt32(httpContext.Request.RouteValues["id"]);

            //        string owner = httpContext.Request.RouteValues["owner"].ToString();

            //        await httpContext.Response.WriteAsync($"Order id is => {id}, owner is {owner}");
            //    });



            //});

            //app.Run(async (HttpContext) =>
            //{
            //    await HttpContext.Response.WriteAsync("Your Requested page is not found!!");
            //});

            #endregion

            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default", // route name
                pattern: "/{Controller=Home}/{action=Index}"
                );

            app.Run();
        }
    }
}
