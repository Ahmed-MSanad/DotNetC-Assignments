using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_1.Case_1;

namespace Assignment_1.TheSalesPerson
{
    public class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        public int VacationStock { get; set; } // No check for vacationStock here at SalesPerson then override it with no check.
        public bool CheckTarget(int Quota)
        {
            if(AchievedTarget > Quota)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCauseEnum.TargetNotAchieved });
                Console.WriteLine($"This Employee {this} is Fired as {LayOffCauseEnum.TargetNotAchieved}");
                return false;
            }
            return true;
        }

        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if(e.Cause != LayOffCauseEnum.NoVacationStockRest)
            {
                base.OnEmployeeLayOff(e);
            }
        }
    }
}
