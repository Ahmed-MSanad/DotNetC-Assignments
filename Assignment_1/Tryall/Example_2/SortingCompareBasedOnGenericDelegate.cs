using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Session_12.Delegate_Example_2_With_Generics
{
    public static class SortingCompareBasedOnGenericDelegate
    {
        public static bool SortNumbersDesc(int x, int y)
        {
            return x < y;
        }

        public static bool SortNumbersAsc(int x, int y)
        {
            return x > y;
        }

        public static bool SortStringsDesc(string x, string y)
        {
            return x?.Length < y?.Length;
        }

        public static bool SortStringsAsc(string x, string y)
        {
            return (x?.Length ?? 0) > (y?.Length ?? 0);
        }
        // it's preferred for SortNumbersDesc and SortStringsDesc to be SortDesc and same for Asc as this will be more efficient if we will do more overloads.
    }
}
