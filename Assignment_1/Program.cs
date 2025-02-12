using System;
using Assignment_1.Case_1;
using Assignment_1.TheClub;
using Assignment_1.TheDepartment;
using Assignment_1.TheSalesPerson;
using Assignment_1.TheBoardMember;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Company Program

            Employee[] Employees = {
                new Employee() { Name = "Ahmed", BirthDate = new DateTime(1995, 10, 26), EmployeeID = 123, VacationStock = 20 },
                new Employee() { Name = "Fatima", BirthDate = new DateTime(1982, 05, 15), EmployeeID = 456, VacationStock = 15 },
                new Employee() { Name = "Ali", BirthDate = new DateTime(1978, 11, 03), EmployeeID = 789, VacationStock = 25 },
                new Employee() { Name = "Salma", BirthDate = new DateTime(1990, 02, 28), EmployeeID = 101, VacationStock = 18 },
                new Employee() { Name = "Ibrahim", BirthDate = new DateTime(1990, 07, 12), EmployeeID = 112, VacationStock = 30 },
            };

            SalesPerson TheSalesPerson = new SalesPerson() 
            { 
                Name = "Mostafa", 
                VacationStock = 10, 
                BirthDate = new DateTime(1993, 12, 23), 
                AchievedTarget = 200,
                EmployeeID = 100
            };

            BoardMember TheBoardMember = new BoardMember()
            {
                Name = "Samir",
                VacationStock = 20,
                BirthDate = new DateTime(1983, 12, 22),
                EmployeeID = 200
            };

            Department HR = new Department() { DeptID = 200, DeptName = "Human Resources" };

            Club RealMadrid = new Club() { ClubID = 100, ClubName = "Real Madrid" };

            foreach (Employee e in Employees)
            {
                HR.AddStaff(e);
                RealMadrid.AddMember(e);
            }


            Employees[0].BirthDate = new DateTime(1933, 2, 23); // >> 60 then should fired from department only.
            
            Console.WriteLine("------------------------------------------------------");

            Employees[1].VacationStock -= 20; // >> 15 then should fired from department and club.

            Console.WriteLine("------------------------------------------------------");

            TheSalesPerson.CheckTarget(100); // 100 is less than target = 200 then employee should be Fired.

            Console.WriteLine("------------------------------------------------------");

            TheBoardMember.BirthDate = new DateTime(1950, 3, 4); // No Event Should Fire 

            Console.WriteLine("------------------------------------------------------");

            TheBoardMember.Resign(); // Resignation Event should fire.


            #endregion


        }
    }
}
