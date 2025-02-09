using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Part2
{
    public delegate string BookDelegate(Book B); // a) User Defined Delegate
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, BookDelegate fPtr) // a) User Defined Delegate
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr) // b) Use the Proper build in delegate.
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

    }
}
