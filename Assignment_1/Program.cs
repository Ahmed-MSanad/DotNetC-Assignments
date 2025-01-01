using Assignment_1.Structs;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment_5

            #region 1) Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] person = new Person[3];

            //person[0].Name = "Ahmed Mahmoud Sanad Abdullah";
            //person[0].Age = 20;

            //person[1].Name = "Mohamed Abn Abdullah";
            //person[1].Age = 63;

            //person[2].Name = "Mosa Mohamed Ibrahim";
            //person[2]["Mosa Mohamed Ibrahim"] = 33;

            //Console.WriteLine("Displaying all Persons Details: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    person[i].DisplayPerson();
            //}

            //// OR:
            //Console.WriteLine("=======================================");

            //Console.WriteLine("Displaying all Persons Details: ");
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Person({i}) => Name is {person[i].Name} and Age is {person[i].Age}");
            //}

            #endregion


            #region 2) Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Console.WriteLine("Enter coordinates for Point 1:");
            //Console.Write("X: ");
            //double x1;
            //while (!double.TryParse(Console.ReadLine(), out x1))
            //{
            //    Console.WriteLine("Invaild Coordinate!");
            //    Console.WriteLine("Enter X coordinate for Point 1:");
            //    Console.Write("X: ");
            //}

            //Console.Write("Y: ");
            //double y1;
            //while (!double.TryParse(Console.ReadLine(), out y1))
            //{
            //    Console.WriteLine("Invaild Coordinate!");
            //    Console.WriteLine("Enter Y coordinate for Point 1:");
            //    Console.Write("Y: ");
            //}

            //Console.WriteLine("Enter coordinates for Point 2:");
            //Console.Write("X: ");
            //double x2;
            //while (!double.TryParse(Console.ReadLine(), out x2))
            //{
            //    Console.WriteLine("Invaild Coordinate!");
            //    Console.WriteLine("Enter X coordinate for Point 2:");
            //    Console.Write("X: ");
            //}

            //Console.Write("Y: ");
            //double y2;
            //while (!double.TryParse(Console.ReadLine(), out y2))
            //{
            //    Console.WriteLine("Invaild Coordinate!");
            //    Console.WriteLine("Enter Y coordinate for Point 2:");
            //    Console.Write("Y: ");
            //}


            //Point point1 = new Point();
            //point1.X = x1;
            //point1.Y = y1;

            //Point point2 = new Point();
            //point2.X = x2;
            //point2.Y = y2;

            //double distance = point1.GetDistance(point2);

            //Console.WriteLine($"Distance between points: {distance}");

            #endregion


            #region 3) Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.

            //_Person[] people = new _Person[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Enter details for Person {i + 1}:");

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine() ?? "Unknown";

            //    int age;
            //    Console.Write("Age: ");
            //    while (!int.TryParse(Console.ReadLine(), out age) || age < 0)
            //    {
            //        Console.WriteLine("Invalid age. Please enter a non negative integer.");
            //        Console.Write("Age: ");
            //    }

            //    people[i] = new _Person(name, age);
            //}

            //_Person oldestPerson = FindOldestPerson(people);
            //Console.WriteLine("\nThe oldest person is:");
            //Console.WriteLine($"Name: {oldestPerson.GetName()}");
            //Console.WriteLine($"Age: {oldestPerson.GetAge()}");

            #endregion

            #endregion
        }
        static _Person FindOldestPerson(_Person[] people)
        {
            _Person oldest = people[0];
            for (int i = 1; i < people.Length; i++)
                if (people[i].GetAge() > oldest.GetAge())
                    oldest = people[i];
            return oldest;
        }
    }
}
