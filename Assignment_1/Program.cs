using System.ComponentModel;
using System.Net;
using Assignment_1.Enum_4_Permissions;
using Assignment_1.Enum_5_Colors;
using Assignment_1.Enums;
using Assignment_1.Enums_2;
using Assignment_1.Enums_3;
using Assignment_1.UserDefinedDatatypes;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Assignment4

            #region part01-1) Try all what we have learned in the lecture.

            #region Private access modifier can't be accessed outside it's structure.
            //Person person = new Person() { age = 12, ID = 111, Name = "Ahmed" };
            ////person.X = 12; // Can't Access X directly.
            //person.setX(12); // Access it through a Setter.
            #endregion

            #region Protected is related to inheritance → in case we don’t want a method or variable to be accessed from outside except from within the inherits either these inherits in the same Project or another project
            //Person person = new Person() { age = 12, ID = 111, Name = "Ahmed" };
            //Child child = new Child();
            //child.showY(); // 20 and not 55
            //person.showY(); // 55 and not 20
            ////person.Y // Error -> Can't access Protected here.
            #endregion

            #region Private Protected → Can be accessed within the class itself or the inherits that only within the same project (or with other tong in the same assembly).
            //Person person = new Person() { age = 12, ID = 111, Name = "Ahmed" };
            //Child child = new Child();
            ////person.Z // Private Protected can't be accessed here
            //child.showZ(); // 20 and not 55
            //person.showZ(); // 55 and not 20
            #endregion

            #region Internal → Can be accessed from everywhere within the same project only.

            //Person person = new Person() { age = 12, ID = 111, Name = "Ahmed" };
            //Child child = new Child();
            //Console.WriteLine(person.W); // 55
            //person.W = 100;
            //Console.WriteLine(person.W); // 100
            //Console.WriteLine(child.W); // 20

            #endregion

            #region Protected Internal -> Can be accessed from everywhere within the same project or inherits from outside the project.
            //Person person = new Person() { age = 12, ID = 111, Name = "Ahmed" };
            //Child child = new Child();
            //Console.WriteLine(person.E); // 55
            //person.E = 100;
            //Console.WriteLine(person.E); // 100
            //Console.WriteLine(child.E); // 20
            #endregion

            #region Public -> Can be accessed from everywhere within the solution.
            //Person person = new Person() { age = 12, ID = 111, Name = "Ahmed" };
            //Child child = new Child();
            //Console.WriteLine(person.Name); // Ahmed
            //person.age = 100;
            //Console.WriteLine(person.age); // 100
            //Console.WriteLine(child.age); // 20
            #endregion

            #region Enum -> Enumeration -> Exampl_1

            //Person person = new Person() { age = 12, ID = 111, Name = "Ahmed" };

            //person.Gender = Gender.Male;

            //Console.WriteLine(person.Gender); // Male

            #endregion

            #region Enum -> Enumeration -> Exampl_2

            //Grade grade = Grade.E;
            //Console.WriteLine(grade); // E
            //Console.WriteLine(grade == Grade.E); // True

            ////grade = 5; // Error
            //grade = (Grade)5;
            //Console.WriteLine(grade); // F

            //grade = (Grade)6;
            //Console.WriteLine(grade); // 6

            //grade = new Grade();
            //Console.WriteLine(grade); // A // which is the first Enum Label

            #endregion

            #region Enum -> Enumeration -> Exampl_3

            //Student student = new Student();
            //bool isPassed;

            //int id;
            //do
            //{
            //    Console.WriteLine("Enter Student Id: ");
            //    isPassed = int.TryParse(Console.ReadLine(), out id);
            //    if (!isPassed)
            //        Console.WriteLine("Invalid !!");
            //} while (!isPassed);
            //student.Id = id;

            //Console.WriteLine("Enter Student Name: ");
            //student.Name = Console.ReadLine();

            //object stuGender;
            //do
            //{
            //    Console.WriteLine("Enter Correct Student Gender: ");
            //    isPassed = Enum.TryParse(typeof(Gender), Console.ReadLine(), out stuGender);
            //    if (!isPassed)
            //        Console.WriteLine("Invalid !!");
            //} while (!isPassed);
            //student.Gender = (Gender)stuGender;

            //object stuGrade;
            //do
            //{
            //    Console.WriteLine("Enter Correct Student Grade: ");
            //    isPassed = Enum.TryParse(typeof(Grade), Console.ReadLine(), out stuGrade);
            //    if (!isPassed)
            //        Console.WriteLine("Invalid !!");
            //} while (!isPassed);
            //student.Grade = (Grade)stuGrade;

            //object stuBranch;
            //do
            //{
            //    Console.WriteLine("Enter Correct Student Branch: ");
            //    isPassed = Enum.TryParse(typeof(Branch), Console.ReadLine(), true, out stuBranch);
            //    if (!isPassed)
            //        Console.WriteLine("Invalid !!");
            //} while (!isPassed);
            //student.Branch = (Branch)stuBranch;


            //Console.WriteLine($"ID: {student.Id}");
            //Console.WriteLine($"Name: {student.Name}");
            //Console.WriteLine($"Gender: {student.Gender}");
            //Console.WriteLine($"Grade: {student.Grade}");
            //Console.WriteLine($"Branch: {student.Branch}");

            #endregion

            #region Enumeration -> Exampl_4 -> Combine Enums

            //User user = new User();

            //user.permission = (Permission)4;
            //Console.WriteLine(user.permission); // Read

            //user.permission = (Permission)10;
            //Console.WriteLine(user.permission); // Execute, Write

            //user.permission = (Permission)15;
            //Console.WriteLine(user.permission); // Delete, Execute, Read, Write

            //// Xor Can trigger Permissions in this case:
            //user.permission = (Permission)13;
            //Console.WriteLine(user.permission); // Delete, Read, Write
            //user.permission = user.permission ^ Permission.Execute;
            //Console.WriteLine(user.permission); // Delete, Execute, Read, Write
            //user.permission = user.permission ^ Permission.Execute;
            //Console.WriteLine(user.permission); // Delete, Read, Write

            //// Remove all permissions Except the delete
            //user.permission = (Permission)15;
            //Console.WriteLine(user.permission); // Delete, Execute, Read, Write
            //user.permission = user.permission & Permission.Delete;
            //Console.WriteLine(user.permission); // Delete

            //// Remove all permissions Except the delete and execute
            //user.permission = (Permission)15;
            //Console.WriteLine(user.permission); // Delete, Execute, Read, Write
            //user.permission = user.permission & (Permission.Delete | Permission.Execute);
            //Console.WriteLine(user.permission); // Delete, Execute

            //// Make sure to have the read
            //user.permission = user.permission | Permission.Read;
            //Console.WriteLine(user.permission); // Delete, Execute, Read

            #endregion

            #region Enum Methods

            //string branch = "Alex";
            //Branch branch1 = (Branch)Enum.Parse(typeof(Branch), branch); // explicit casting is required as Enum.Parse returns an object


            //string[] branchesNames = Enum.GetNames(typeof(Branch));
            //foreach (string branchesName in branchesNames)
            //    Console.WriteLine(branchesName);

            //Array branchesValues = Enum.GetValues(typeof(Branch));
            //foreach (int branchesValue in branchesValues)
            //    Console.WriteLine(branchesValue);


            //bool isExist = Enum.IsDefined(typeof(Branch), "Alex");
            //Console.WriteLine(isExist);
            //isExist = Enum.IsDefined(typeof(Branch), "alex");
            //Console.WriteLine(isExist);
            //isExist = Enum.IsDefined(typeof(Branch), 99);
            //Console.WriteLine(isExist);

            #endregion

            #region HttpStatusCode -> Built-in Enum

            //HttpStatusCode httpStatusCode = new HttpStatusCode();

            #endregion

            #endregion


            #region part02-1) Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //foreach(string weekDay in Enum.GetNames(typeof(E_WeekDays)))
            //    Console.WriteLine(weekDay);

            //// or 

            //E_WeekDays[] daysOfWeek = (E_WeekDays[])Enum.GetValues(typeof(E_WeekDays));
            //foreach (E_WeekDays day in daysOfWeek)
            //    Console.WriteLine(day);

            #endregion


            #region 2) Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as  its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //object season;

            //Console.Write("Enter the season name to display the corresponding month range for that season: ");
            //while(!Enum.TryParse(typeof(Season), Console.ReadLine(),true ,out season))
            //{
            //    Console.WriteLine("Not Valid Season Name!!");
            //    Console.Write("Enter the season name to display the corresponding month range for that season: ");
            //}

            //string msg = season switch
            //{
            //    Season.Spring => "march to may",
            //    Season.Summer => "june to august",
            //    Season.Autumn => "September to November",
            //    Season.Winter => "December to February",
            //    _ => "Nothing"
            //};
            //Console.WriteLine(msg);

            #endregion

            #region 3) Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum. Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //Permissions permissions = new Permissions();

            //Console.WriteLine(permissions); // 0

            //permissions ^= Permissions.Delete; // give delete permission
            //Console.WriteLine(permissions); // Delete

            //permissions ^= (Permissions.Read | Permissions.Execute); // give both execute and read permission
            //Console.WriteLine(permissions); // Read, Execute, Delete

            //permissions &= ~(Permissions.Read | Permissions.Delete); // remove delete and read permissions
            //Console.WriteLine(permissions); // Execute

            //permissions = (Permissions)15;
            //Console.WriteLine(permissions); // Read, Write, Execute, Delete

            //Permissions p = permissions & Permissions.Execute;
            //if (p == Permissions.Execute)
            //    Console.WriteLine("Execute is allowed"); // Execute is allowed

            //permissions = permissions & ~Permissions.Execute;
            //Console.WriteLine(permissions); // Read, Write, Delete

            //p = permissions & Permissions.Execute;
            //if (p == Permissions.Execute)
            //    Console.WriteLine("Execute is allowed"); // Execute is Not allowed
            //else
            //    Console.WriteLine("Execute is Not allowed");

            #endregion

            #region 4) Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not

            //Console.WriteLine("Enter a color name (Red, Green, Blue):");
            //string inputColor = Console.ReadLine();

            //if (Enum.TryParse(inputColor, true, out Colors color))
            //    Console.WriteLine($"{inputColor} is a primary color.");
            //else
            //    Console.WriteLine($"{inputColor} is not a primary color.");

            #endregion

            #endregion


        }
    }
}
