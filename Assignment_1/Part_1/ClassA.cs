using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Part_1
{
    internal class ClassA
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public ClassA(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public ClassA(int a, int b)
        {
            A = a;
            B = b;
        }
        public ClassA(int a)
        {
            A = a;
        }
    }
}
