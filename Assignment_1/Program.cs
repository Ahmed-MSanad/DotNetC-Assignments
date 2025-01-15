using Assignment_1.Company;
using Assignment_1.Part_1;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment_6 

            #region 1. Try all what we have learned in the lecture.

            //// 1) default class parameterless constructor is not avaliable if we created at least 1 user-defined constructor:

            //// 1.1) using the compiler default parameterless constructor:
            ////ClassA A1 = new();
            ////ClassA A2 = new ClassA();

            //// 1.2) using the compiler default parameterless constructor won't be allowed after we added a user-defined constructor so the above will get errors:
            //ClassA A1 = new(1, 2);
            //ClassA A2 = new ClassA(3, 4);

            //// 1.3) Constructor Overloading -> is done by adding multiple constructors with different signature:
            //ClassA A3 = new ClassA(4);
            //ClassA A4 = new ClassA(4, 5);
            //ClassA A5 = new ClassA(4, 5, 6);


            ////2) Constructor Chainning -> class to itself & class to it's only parent(multi-class is not allowed in C#):

            //// 2.1) class to itself:
            //Student ahmed = new Student(20, "ahmed sanad", 1000);
            //Console.WriteLine($"Name: {ahmed.Name} , Age: {ahmed.Age} , Grade: {ahmed.Grade}");

            //Student samir = new Student(30, "samir ahmed");
            //Console.WriteLine($"Name: {samir.Name} , Age: {samir.Age} , Grade: {samir.Grade}");

            //Student unknown = new Student(40);
            //Console.WriteLine($"Name: {unknown.Name} , Age: {unknown.Age} , Grade: {unknown.Grade}");


            //// 2.2) class to it's only parent(multi-class is not allowed in C#):

            //Child hossam = new Child(22, "Hossam Ashraf", 2000, 5);
            //Console.WriteLine($"Name: {hossam.Name} , Age: {hossam.Age} , Grade: {hossam.Salary}, Number Of Children: {hossam.NumberOfChildren}");


            //// 2.3) Child Override A Parent Method:

            //Parent yasser = new Parent(10);
            //yasser.TakeCareOfChildren(yasser.NumberOfChildren);

            //Child mohsen = new Child(12, "mohsen", 0, 0);
            //mohsen.TakeCareOfChildren(20);

            #endregion

            #region 1. Design and implement a Class for the employees in a company
            /* Notes:
                    Employee is identified by an ID, Name, security level, salary, hire date
                        and Gender.
                    We need to restrict the Gender field to be only M or F [Male or Female]
                    Assign the following security privileges to the employee (guest,
                        Developer, secretary and DBA) in a form of Enum.
                    We want to provide the Employee Class to represent Employee data in a
                        string Form (override ToString ()), display employee salary in a currency
                        format. [Use String.Format() Function].
             */


            //Employee ahmed = new Employee(122, "ahmed sanad", SecurityPrivileges.Developer, new HiringDate() { Day = 12, Month = 3, Year = 2002}, 1200, Gender.Male);

            //Console.WriteLine(ahmed.ToString());

            #endregion

            #region 2. Develop a Class to represent the Hiring Date Data
            /* Consisting of fields to hold the day, month and Years. */


            //HiringDate date = new HiringDate();

            //date.Day = 25;
            //date.Month = 3;
            //date.Year = 20999;

            //Console.WriteLine(date.ToString());

            #endregion

            #region 3. Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            /*Notes:
                    Implement All the Necessary Member Functions on the Class
                        (Getters, Setters)
                    Define all the Necessary Constructors for the Class
                    Allow NO RUNTIME errors if the user inputs any data
                    Write down all the necessary Properties (Instead of setters
                    and getters)
            */

            //Employee[] EmpArr = new Employee[2];

            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    EmpArr[i] = new Employee();
            //}

            //foreach (Employee employee in EmpArr)
            //{
            //    // security officer will take 15 for full permissions
            //    employee.EnterEmployeeData();
            //    Console.WriteLine("===================================");
            //}

            //foreach (Employee employee in EmpArr)
            //{
            //    Console.WriteLine(employee.ToString());
            //}

            #endregion

            #region 4. Sort the employees based on their hire date then Print the sorted array.
            /*While sorting (how many times Boxing and Unboxing process
                has occurred)
            */


            //Console.WriteLine("=========================== After Sorting ===========================");

            //for (int i = 0; i < EmpArr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < EmpArr.Length; j++)
            //    {
            //        if (EmpArr[j].HireDate.Year < EmpArr[i].HireDate.Year ||
            //            (EmpArr[j].HireDate.Year == EmpArr[i].HireDate.Year && EmpArr[j].HireDate.Month < EmpArr[i].HireDate.Month) ||
            //            (EmpArr[j].HireDate.Year == EmpArr[i].HireDate.Year && EmpArr[j].HireDate.Month == EmpArr[i].HireDate.Month &&
            //             EmpArr[j].HireDate.Day < EmpArr[i].HireDate.Day))
            //        {
            //            Employee temp = EmpArr[i];
            //            EmpArr[i] = EmpArr[j];
            //            EmpArr[j] = temp;
            //        }
            //    }
            //}

            //foreach (Employee employee in EmpArr)
            //{
            //    Console.WriteLine(employee.ToString());
            //}


            // no Boxing Or Unboxing happened here ..

            #endregion

            #endregion
        }
    }
}
