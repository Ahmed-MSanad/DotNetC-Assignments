using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_1.Case_1;

namespace Assignment_1.TheDepartment
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff;
        public Department()
        {
            Staff = new List<Employee>();
        }
        public void AddStaff(Employee E)
        {
            if(E != null && !Staff.Contains(E))
            {
                Staff.Add(E);
                ///Try Register for EmployeeLayOff Event Here
                E.EmployeeLayOff += RemoveStaff;
            }
        }
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is Employee employee && Staff.Contains(employee))
            {
                Staff.Remove(employee);
                Console.WriteLine($"This Employee {employee} is Removed from the Department: {DeptName} because of: {e.Cause}.");
            }
        }
    }
}
