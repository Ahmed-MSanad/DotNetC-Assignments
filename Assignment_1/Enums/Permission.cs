using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Enums
{
    [Flags] // this is an attribute and differ from the properties
    public enum Permission : byte
    {
        Delete = 1,
        Execute = 2,
        Read = 4,
        Write = 8,
    }
}
