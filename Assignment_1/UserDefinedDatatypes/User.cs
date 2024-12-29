using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Assignment_1.Enums;

namespace Assignment_1.UserDefinedDatatypes
{
    internal class User
    {
        public int Id { get; set; }

        public Permission permission { get; set; }
    }
}
