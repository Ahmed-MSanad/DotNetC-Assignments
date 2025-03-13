using Assignment_1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using CompanyDbContext context = new CompanyDbContext();

                //Car car01 = new Car
                //{
                //    Make = "Tesla",
                //    Model = "ModelX",
                //    NumberOfDoors = 2
                //};

                //Car car02 = new Car
                //{
                //    Make = "Tesla",
                //    Model = "ModelX2",
                //    NumberOfDoors = 4
                //};

                //Truck truck01 = new Truck
                //{
                //    Make = "Ford",
                //    Model = "FX",
                //    LoadCapacity = 500
                //};

                //Truck truck02 = new Truck
                //{
                //    Make = "Ford",
                //    Model = "FX2",
                //    LoadCapacity = 700
                //};


                //context.Add(car01);
                //context.Vehicles.Add(car02);
                //context.Set<Truck>().Add(truck01);
                //context.Add(truck02);

                //context.SaveChanges();

                // ----------------------------------------------- How to get cars despite there is no existence for the discrminator in C#:
                //var cars = context.Vehicles.Where(x => EF.Property<string>(x, "VehicleType") == "Car").ToList();

                //foreach (var car in cars)
                //    Console.WriteLine(car);

                // OR:

                //foreach (var car in context.Vehicles.OfType<Car>())
                //    Console.WriteLine(car);


                // If we added a DbSet for Car in the context, we can get the cars directly from the Cars DbSet:
                //foreach (var car in context.Cars)
                //    Console.WriteLine(car);




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
        }
    }
}
