using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Case_1
{
    public class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs>? EmployeeLayOff;

        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        private DateTime birthDate;
        public DateTime BirthDate
        {
            get => birthDate;

            set 
            {
                if(DateTime.Now.Year - value.Year >= 60)
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCauseEnum.AgeIs60 });
                }
                birthDate = value;
            }
        }
        private int vacationStock;
        public int VacationStock
        {
            get => vacationStock;

            set
            {
                if (value < 0)
                {
                    OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCauseEnum.NoVacationStockRest });
                }
                vacationStock = value;
            }
        }
        public bool RequestVacation(DateTime From, DateTime To)
        {
            VacationStock -= (To - From).Days;
            if(VacationStock >= 0)
            {
                return true;
            }
            return false;
        }
        public void EndOfYearOperation()
        {
            if(DateTime.Now.Year - BirthDate.Year >= 60)
            {
                OnEmployeeLayOff(new EmployeeLayOffEventArgs() { Cause = LayOffCauseEnum.AgeIs60 });
            }
        }

        public override string ToString()
        {
            return $"ID: {EmployeeID}, Name: {Name}";
        }
    }
}
