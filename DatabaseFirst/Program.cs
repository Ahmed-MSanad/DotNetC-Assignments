using System.Collections.Generic;
using DatabaseFirst.Contexts;
using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stored Procedure

            //using NorthwindContext context = new NorthwindContext();

            //NorthwindContextProcedures contextProcedures = new NorthwindContextProcedures(context);

            //// => NOTE: **we need to add the "TrustServerCertificate=True;" as it's not set by the Extension when doing Database First**
            //var products = contextProcedures.SalesByCategoryAsync("Beverages", "1998").Result;
            //// => NOTE: **Without .Result -> returns Task<>**

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName}, Product Total Purchase: {product.TotalPurchase}");
            //}

            #endregion

            #region Run SQL Query

            //using (NorthwindContext context = new NorthwindContext())
            //{
            // => ******************************** Select Statement:

            //var result = context.Categories.FromSqlRaw("select * from Categories").ToList();

            //string categoryName = "Beverages";
            //var result = context.Categories.FromSqlInterpolated($"Select * from Categories where CategoryName = {categoryName}").ToList();

            //var result = context.Categories.Where(category => category.CategoryName == "Beverages");

            //var result = from category in context.Categories
            //             where category.CategoryName == "Beverages"
            //             select category;

            //foreach (var category in result)
            //{
            //    Console.WriteLine($"Category Name: {category.CategoryName}, Category Description: {category.Description}");
            //}


            // => ******************************** Execute DML Query:

            //int ProductId = 2;
            //context.Database.ExecuteSqlInterpolated($"Update products set ProductName = 'Chai02' where ProductId = {ProductId}");

            //}

            #endregion

            #region Lazy & Eager Loading

            //using NorthwindContext context = new NorthwindContext();

            //var products = context.Products.ToList();
            //foreach (var product in products)
            //    Console.WriteLine($"{product.ProductID} :: {product.UnitPrice} :: {product.Category.CategoryName}");
            ////product.Category.CategoryName -> because of data Lazy loading -> Category is null and this will throw an exception

            //var product1 = context.Products.FirstOrDefault();
            //var categoryName1 = product1.Category.CategoryName; // same as the error above.


            //var product2 = context.Products.Include(x => x.Category).FirstOrDefault();
            //var categoryName2 = product2.Category.CategoryName;
            //Console.WriteLine(categoryName2);


            // // If we want to load all products of that category of that first product:
            //var product3 = context.Products.Include(x => x.Category).ThenInclude(x => x.Products).FirstOrDefault();
            //var categoryName3 = product3.Category.CategoryName;
            //Console.WriteLine($"Category Name: {categoryName3}");
            //foreach(var product in product3.Category.Products)
            //    Console.WriteLine($"ProductName: {product.ProductName}, UnitPrice: {product.UnitPrice}");


            //// If we want to include more than 1 level of navigation property:
            //var product4 = context.Products.Include(x => x.Category).Include(x => x.Supplier).FirstOrDefault();
            //var categoryName4 = product4.Category.CategoryName;
            //Console.WriteLine($"Category Name: {categoryName4}");
            //Console.WriteLine($"ProductName: {product4.ProductName}, CompanyName: {product4.Supplier.CompanyName}");


            // // Loading the category in a separate request(Explicit Loading):

            // // navigational property that is a single object: 
            //var product5 = context.Products.FirstOrDefault();
            //context.Entry(product5).Reference(x => x.Category).Load(); // Reference work with navigational property that is a single object
            //Console.WriteLine(product5.Category.CategoryName);

            // // navigational property that is a collection:
            //var product6 = context.Products.FirstOrDefault();
            //context.Entry(product6).Collection(x => x.Order_Details).Load(); // Collection work with navigational property that is a collection
            //foreach(var order_details in product6.Order_Details)
            //    Console.WriteLine($"OrderID: {order_details.OrderID}, Quantity: {order_details.Quantity}");

            #endregion

            #region Proxies Package

            //using NorthwindContext context = new NorthwindContext();

            //var product = context.Products.FirstOrDefault();

            //Console.WriteLine(product.Category.CategoryName);

            // //** Trun on it first -> => optionsBuilder.UseLazyLoadingProxies(false) ** false -> true.

            #endregion

            #region Remote & Local

            // // Check if any product is out of stock:

            //using NorthwindContext context = new NorthwindContext();

            ////var isThereAnyProductOutOfStock1 = context.Products.Any(x => x.UnitsInStock == 0);
            ////if (isThereAnyProductOutOfStock1)
            ////    Console.WriteLine("There is/are Products Out Of Stock");
            ////else
            ////    Console.WriteLine("There is no Product Out Of Stock");


            //// This above SQL Request will be executed every time we run -> can cach requests or responses using "redis cache"
            ////      to lessen the number of requests to the Database and improving the performance by quicker respond.


            //context.Products.Load(); // loading the data locally:

            //var isThereAnyProductOutOfStock = context.Products.Local.Any(x => x.UnitsInStock == 0);
            //if (isThereAnyProductOutOfStock)
            //    Console.WriteLine("There is/are Products Out Of Stock");
            //else
            //    Console.WriteLine("There is no Product Out Of Stock");


            #endregion

        }
    }
}
