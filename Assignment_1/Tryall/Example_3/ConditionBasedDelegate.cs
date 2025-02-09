using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Session_12.More_Generics
{
    public static class ConditionBasedDelegate
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsDevideBy7(int number)
        {
            return number % 7 == 0;
        }

        public static bool IsLengthMoreThan3(string x)
        {
            return x?.Length > 3;
        }

        public static bool IsStartWithA(string x)
        {
            return char.ToUpper(x[0]) == 'A';
        }
    }
}
