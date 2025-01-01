using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Structs
{
    internal struct _Person
    {
        string name;
        int age;

        public _Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void SetName(string name)
        {
            this.name = name.Length <= 20 ? name : name.Substring(0, 20);
        }
        public void SetAge(int age)
        {
            if (age <= 60)
                this.age = age;
            else
                Console.WriteLine("Please Enter Age from 18 to 60 only!");
        }

        public string GetName() { return this.name; }

        public int GetAge() { return this.age; }
    }
}
