using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_1.Enums;

namespace Assignment_1.UserDefinedDatatypes
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Gender Gender { get; set; }

        public Grade Grade { get; set; }

        public Branch Branch { get; set; }
    }
}
