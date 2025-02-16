using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.CustomComparer
{
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            x = x.ToLower();
            y = y.ToLower();
            return string.Compare(x, y);

            // OR:

            //return string.Compare(x, y, true);
        }
    }
}
