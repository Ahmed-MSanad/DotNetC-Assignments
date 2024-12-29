using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Enum_4_Permissions
{
    [Flags]
    public enum Permissions : byte
    {
        Read = 1,
        Write = 2,
        Execute = 4,
        Delete = 8,
    }
}
