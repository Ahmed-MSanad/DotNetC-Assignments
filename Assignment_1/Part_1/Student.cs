using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Part_1
{
    internal class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public float Grade { get; set; }

        public Student(int age, string name, float salary)
        {
            Age = age;
            Name = name;
            Grade = salary;
        }

        public Student(int age, string name) : this(age, name, 100.0f) { }

        public Student(int age) : this(age, "unknown", 10.0f) { }
    }
}
