using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_1.Case_1;

namespace Assignment_1.TheBoardMember
{
    public class BoardMember : Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCauseEnum.Resigned });
            Console.WriteLine($"This Employee {this} is resigned");
        }
        public DateTime BirthDate { get; set; } // Board Member has no retiring Age (will not be Fired if AGE > 60).
        public int VacationStock { get; set; } // Board Member is not a Full time Employee (Has no vacation Stock).
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if(e.Cause == LayOffCauseEnum.Resigned)
                base.OnEmployeeLayOff(e);
        }
    }
}
