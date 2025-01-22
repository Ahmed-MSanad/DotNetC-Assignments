using System.Drawing;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using Assignment_1.First_Project;
using Assignment_1.Second_Project;
using Assignment_1.Third_Project;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            #region First Project
            /*
                1. Define 3D Point Class and the basic Constructors(use chaining in constructors).
                2. Override the ToString Function to produce this output:
                 Point3D P = new Point3D(10, 10, 10);
                 Console.WriteLine(P.ToString());
                 Output: “Point Coordinates: (10, 10, 10)”.
            */

            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());


            //3. Read from the User the Coordinates for 2 points P1, P2(Check the input using try Pares, Parse, Convert):

            //Point3D P1 = new Point3D(0, 0, 0),
            //        P2 = new Point3D(0, 0, 0);


            //Console.WriteLine("Please Enter The Coordinates of 2 points: ");

            //decimal x;
            //Console.WriteLine("P1x: ");
            //while (!decimal.TryParse(Console.ReadLine(), out x))
            //{
            //    Console.WriteLine("Wrong input !! please input correct number.");
            //    Console.WriteLine("P1x: ");
            //}
            //P1.x = x;


            //Console.WriteLine("P1y: ");
            //P1.y = decimal.Parse(Console.ReadLine());


            //Console.WriteLine("P1z: ");
            //P1.z = Convert.ToDecimal(Console.ReadLine());


            //Console.WriteLine("P2x: ");
            //while (!decimal.TryParse(Console.ReadLine(), out x))
            //{
            //    Console.WriteLine("Wrong input !! please input correct number.");
            //    Console.WriteLine("P2x: ");
            //}
            //P2.x = x;


            //Console.WriteLine("P2y: ");
            //P2.y = decimal.Parse(Console.ReadLine());


            //Console.WriteLine("P2z: ");
            //P2.z = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine(P1.ToString());
            //Console.WriteLine(P2.ToString());



            //4.Try to use == If(P1 == P2) Does it work properly? 

            //if(P1 == P2)
            //{
            //    Console.WriteLine("P1 == P2");
            //}
            //else
            //{
            //    Console.WriteLine("P1 != P2");
            //}

            // Answer: No it's not working properly.



            //5.Define an array of points and sort this array based on X & Y coordinates.


            //Point3D[] points =
            //{
            //    new Point3D(2, 3, 5),
            //    new Point3D(2, 3, 3),
            //    new Point3D(2, 2, 3),
            //    new Point3D(2, 3, 4),
            //    new Point3D(1, 2, 3),
            //};

            //Console.WriteLine("\n================== Before Sorting ==================\n");
            //foreach (Point3D point in points)
            //    Console.WriteLine(point.ToString());

            //Array.Sort(points);

            //Console.WriteLine("\n================== After Sorting ==================\n");
            //foreach (Point3D point in points)
            //    Console.WriteLine(point.ToString());



            //6.Implement ICloneable interface to be able to clone the object.
            //    To implement more than one interface.
            //    class Point3D : IComparable, ICloneable

            //Point3D point = new Point3D(11, 22, 33);

            //Console.WriteLine(point.ToString());

            //Point3D deepCopyOfPoint = (Point3D)point.Clone();

            //Console.WriteLine(deepCopyOfPoint.ToString());

            #endregion


            #region Second Project

            #region Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters.Call each method in Main().
            // NOTE: to make this section work => remove the staic keyword from the Maths methods in the Maths file.


            //Console.WriteLine("Enter a number of the operation: ");
            //Console.WriteLine("1. +\n2. -\n3. *\n4. / : ");
            //int choice = 0;
            //while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4) {
            //    Console.WriteLine("Wrong Choice !! please Try again.");
            //    Console.WriteLine("1. +\n2. -\n3. *\n4. / : ");
            //}

            //double number1, number2;

            //Console.WriteLine("Enter the first number: ");
            //while (!double.TryParse(Console.ReadLine(), out number1))
            //{
            //    Console.WriteLine("Wrong number!! please try again.");
            //    Console.WriteLine("Enter the first number: ");
            //}

            //Console.WriteLine("Enter the second number: ");
            //while (!double.TryParse(Console.ReadLine(), out number2))
            //{
            //    Console.WriteLine("Wrong number!! please try again.");
            //    Console.WriteLine("Enter the second number: ");
            //}

            //Maths maths = new Maths();

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine($"Result of {number1} + {number2}: {maths.Add(number1, number2)}");
            //    break;
            //    case 2:
            //        Console.WriteLine($"Result of {number1} - {number2}: {maths.Subtract(number1, number2)}");
            //    break;
            //    case 3:
            //        Console.WriteLine($"Result of {number1} * {number2}: {maths.Multiply(number1, number2)}");
            //    break;
            //    case 4:
            //        Console.WriteLine($"Result of {number1} / {number2}: {maths.Divide(number1, number2)}");
            //    break;
            //    default:
            //        Console.WriteLine("Wrong Choice !!");
            //    break;
            //}

            #endregion


            #region Modify the program so that you do not have to create an instance of class to call the four methods.
            // Because of the Static keyword => call the method directly with the Class itself without creating an instance as this will get an error.


            //Console.WriteLine("Enter a number of the operation: ");
            //Console.WriteLine("1. +\n2. -\n3. *\n4. / : ");
            //int choice = 0;
            //while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
            //{
            //    Console.WriteLine("Wrong Choice !! please Try again.");
            //    Console.WriteLine("1. +\n2. -\n3. *\n4. / : ");
            //}

            //double number1, number2;

            //Console.WriteLine("Enter the first number: ");
            //while (!double.TryParse(Console.ReadLine(), out number1))
            //{
            //    Console.WriteLine("Wrong number!! please try again.");
            //    Console.WriteLine("Enter the first number: ");
            //}

            //Console.WriteLine("Enter the second number: ");
            //while (!double.TryParse(Console.ReadLine(), out number2))
            //{
            //    Console.WriteLine("Wrong number!! please try again.");
            //    Console.WriteLine("Enter the second number: ");
            //}

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine($"Result of {number1} + {number2}: {Maths.Add(number1, number2)}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"Result of {number1} - {number2}: {Maths.Subtract(number1, number2)}");
            //        break;
            //    case 3:
            //        Console.WriteLine($"Result of {number1} * {number2}: {Maths.Multiply(number1, number2)}");
            //        break;
            //    case 4:
            //        Console.WriteLine($"Result of {number1} / {number2}: {Maths.Divide(number1, number2)}");
            //        break;
            //    default:
            //        Console.WriteLine("Wrong Choice !!");
            //        break;
            //}

            #endregion

            #endregion


            #region Third Project

            // 1. Define Class Duration To include Three Attributes Hours, Minutes and Seconds. (done)



            // 2. Override All System.Object Members (ToString, Equals,GetHasCode):

            //Duration duration1 = new Duration() { hours = 5, minutes = 44, seconds = 33 };
            //Console.WriteLine(duration1.ToString());

            //Duration duration2 = new Duration() { hours = 5, minutes = 44, seconds = 33 };
            //Console.WriteLine(duration2.ToString());

            //Duration duration3 = new Duration() { hours = 6, minutes = 33, seconds = 22 };
            //Console.WriteLine(duration2.ToString());

            //Console.WriteLine("is duration1 == duration2 ? " + (duration1.Equals(duration2) ? "Yes" : "No"));
            //Console.WriteLine("is duration1 == duration3 ? " + (duration1.Equals(duration3) ? "Yes" : "No"));

            //Console.WriteLine($"duration1 HashCode is: {duration1.GetHashCode()}");

            //Console.WriteLine($"duration2 HashCode is: {duration2.GetHashCode()}");

            //Console.WriteLine($"duration3 HashCode is: {duration3.GetHashCode()}");



            // 3. Define All Required Constructors to Produce this output:

            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());
            //// Output: Hours: 1, Minutes :10, Seconds :15

            //Duration D11 = new Duration(3600);
            //Console.WriteLine(D11.ToString());
            //// Output: Hours: 1, Minutes: 0, Seconds: 0

            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString());
            ////Output: Hours: 2, Minutes: 10, Seconds: 0

            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());
            ////Output: Minutes: 11, Seconds: 6



            #endregion

        }
    }
}
