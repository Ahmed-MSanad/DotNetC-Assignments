using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Assignment_1.Enums;

namespace Assignment_1.UserDefinedDatatypes
{
    public class Person
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int age { get; set; }

        public void print()
        {
            Console.WriteLine("print from the class.");
        }

        private int X;
        public void setX(int Value)
        {
            X = Value;
        }

        protected int Y = 55; // accessed only from within the same class or any inherit
        public void showY()
        {
            Console.WriteLine(Y);
        }

        private protected int Z = 55;
        public void showZ()
        {
            Console.WriteLine(Z);
        }

        internal int W = 55;

        protected internal int E = 55;


        public Gender Gender { get; set; }

    }
}
