using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Session_12.Built_inDelegate
{
    public class TestBuiltDelegates
    {
        public static bool CheckPositive(int number) { return number > 0; }

        public static string Casting(int number) { return number.ToString(); }

        public static void Print() { Console.WriteLine("Hello, "); }

        public static void Print(string name) { Console.WriteLine($"Hello, {name}"); }

    }
}
