using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Structs
{
    internal struct Person
    {
        string name;
        public string Name
        { // Full Property
            get { return this.name; }
            set { name = value.Length <= 20 ? value : value.Substring(0, 20); }
        }

        public int Age { get; set; } // Automatic Property

        public int this[string name]
        {
            get { return this.Age; }
            set { this.Age = value; }
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"Person => Name is {this.Name} and Age is {this.Age}");
        }
    }
}
