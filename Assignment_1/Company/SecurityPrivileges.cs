using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Company
{
    [Flags]
    internal enum SecurityPrivileges
    {
        guest = 1,
        Developer = 2,
        secretary = 4,
        DBA = 8,
    }
}
