using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Company
{
    internal class HiringDate
    {

        private int day;
        public int Day { get => day; set => day = value <= 31 && value > 0 ? value : DateTime.Now.Day; }

        private int month;
        public int Month { get => month; set => month = value <= 12 && value > 0 ? value : DateTime.Now.Month; }

        private int year;
        public int Year { get => year; set => year = value <= DateTime.Now.Year && value > 1999 ? value : DateTime.Now.Year; }
        public override string ToString()
        {
            return $"({Day} / {Month} / {Year})";
        }

    }
}
