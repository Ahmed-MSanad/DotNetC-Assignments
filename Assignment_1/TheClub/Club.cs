using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_1.Case_1;

namespace Assignment_1.TheClub
{
    public class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members;
        public Club()
        {
            Members = new List<Employee>();
        }
        public void AddMember(Employee E)
        {
            if(E is not null && !Members.Contains(E))
            {
                Members.Add(E);
                ///Try Register for EmployeeLayOff Event Here
                E.EmployeeLayOff += RemoveMember;
            }
        }
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
            Employee employee = sender as Employee;

            if (employee is not null && e.Cause == LayOffCauseEnum.NoVacationStockRest && Members.Contains(employee))
            {
                Members.Remove(employee);
                Console.WriteLine($"This Employee {employee} is removed from the Club: {ClubName} because of {e.Cause}.");
            }
        }
    }
}
