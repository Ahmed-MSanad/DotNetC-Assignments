using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Part_1
{
    internal class Parent
    {
        public int NumberOfChildren { get; set; }

        public Parent(int numberOfChildren)
        {
            NumberOfChildren = numberOfChildren;
        }

        public void TakeCareOfChildren(int numberOfChildren)
        {
            Console.WriteLine($"Take Care of your {numberOfChildren} Children");
        }
    }
}
