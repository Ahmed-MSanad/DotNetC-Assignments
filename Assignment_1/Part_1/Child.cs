using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Part_1
{
    internal class Child : Parent
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public Child(int age, string name, float salary, int numOfChildren) : base(numOfChildren)
        {
            Age = age;
            Name = name;
            Salary = salary;
        }

        public new void TakeCareOfChildren(int numOfChildren) // it's prefered to write the new keyword to indicate that you're overriding a parent method
        {
            Console.WriteLine($"Our Dad Must Take care of the {numOfChildren} of us");
        }

    }
}
