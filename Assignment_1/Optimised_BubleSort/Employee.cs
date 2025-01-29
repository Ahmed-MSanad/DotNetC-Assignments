using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Optimised_BubleSort
{
    public class Employee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}";
        }

        public int CompareTo(object? obj)
        {
            Employee employee = obj as Employee;

            if (employee == null) throw new NullReferenceException();

            if (Id > employee?.Id)
                return 1;
            else if (Id < employee?.Id)
                return -1;
            else return 0;
        }

        public static int operator -(Employee a, Employee b)
        {
            return (a?.Id ?? 0) - (b?.Id ?? 0);
        }
    }
}
