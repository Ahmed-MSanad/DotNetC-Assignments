using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Company
{
    internal class Employee
    {

        int employeeId;
        public int EmployeeId { get => employeeId; private set => employeeId = value; }
        string? name;
        public string? Name { get => name; private set => name = value; }
        SecurityPrivileges securityLevel;
        public SecurityPrivileges SecurityLevel { get => securityLevel; private set => securityLevel = value; }
        double salary;
        public double Salary { get => salary; private set => salary = value; }
        HiringDate hireDate;
        public HiringDate HireDate { get => hireDate; private set => hireDate = value; }
        Gender gender;
        public Gender Gender { get => gender; private set => gender = value; }


        public Employee()
        {
            this.HireDate = new HiringDate();
        }

        public Employee(int empId, string name, SecurityPrivileges securityLevel, HiringDate hireDate, double salary, Gender gender)
        {
            this.SecurityLevel = securityLevel;
            this.HireDate = hireDate;
            this.EmployeeId = empId;
            this.Name = name;
            this.Salary = salary;
            this.Gender = gender;
        }

        public override string ToString()
        {
            string empSalary = String.Format("{0:C}", this.Salary.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));

            return @$" ======================== Employee Data ============================
EmployeeId: {this.EmployeeId}, 
Name: {this.Name}, 
SecurityLevel: {this.SecurityLevel}, 
Salary: {empSalary}, 
Gender: {this.Gender}, 
HireDate: {this.HireDate.ToString()}
";
        }


        public void EnterEmployeeData()
        {
            bool isOk;

            do
            {
                Console.WriteLine($"Enter Id Of The Employee: ");
                isOk = int.TryParse(Console.ReadLine(), out this.employeeId);

            } while (!isOk);

            do
            {
                Console.WriteLine($"Enter Name Of The Employee: ");
                this.name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(this.name));

            do
            {
                Console.WriteLine($"Enter Salary Of The Employee: ");
                isOk = double.TryParse(Console.ReadLine(), out this.salary);

            } while (!isOk);


            int choseLevel;
            do
            {
                Console.WriteLine($"Enter Secuirty Level Of The Employee: ");
                Console.WriteLine("1 for guest , 2 for Developer , 4 for secretary , 8 for DBA");
                isOk = int.TryParse(Console.ReadLine(), out choseLevel);

            } while (!isOk || (choseLevel < 0 && choseLevel > 15));
            this.SecurityLevel = (SecurityPrivileges)choseLevel;


            int gender;
            do
            {
                Console.WriteLine($"Enter Gender Of The Employee: ");
                Console.WriteLine("Enter 0 for Male , 1 for Female");
                isOk = int.TryParse(Console.ReadLine(), out gender);
            } while (!isOk || !Enum.IsDefined(typeof(Gender), gender));
            this.gender = (Gender)gender;


            Console.WriteLine("Enter The Hire Date ");
            int day, month, year;

            do
            {
                Console.WriteLine($"Enter Day Of The Employee: ");
                isOk = int.TryParse(Console.ReadLine(), out day);

            } while (!isOk);
            this.HireDate.Day = day;

            do
            {
                Console.WriteLine($"Enter Month Of The Employee: ");
                isOk = int.TryParse(Console.ReadLine(), out month);

            } while (!isOk);
            this.HireDate.Month = month;

            do
            {
                Console.WriteLine($"Enter Year Of The Employee: ");
                isOk = int.TryParse(Console.ReadLine(), out year);

            } while (!isOk);
            this.HireDate.Year = year;
        }

    }
}
