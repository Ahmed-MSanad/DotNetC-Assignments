using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Q2__Range
{
    public class Range<T> where T : IComparable
    {
        public T Start { get; set; }
        public T End { get; set; }
        public Range(T start, T end)
        {
            Start = start;
            End = end;
        }

        public bool IsInRange(T value)
        {
            if(value.CompareTo(Start) >= 0 && value.CompareTo(End) <= 0)
            {
                return true;
            }
            return false;
        }

        public int Length()
        {
            return (dynamic)End - (dynamic)Start + 1; // but dynamic provides no check, and slow
        }
    }
}
