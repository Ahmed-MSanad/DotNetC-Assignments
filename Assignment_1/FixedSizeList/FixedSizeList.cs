using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.FixedSizeList
{
    public class FixedSizeList<T>
    {
        public int Length { get; set; }
        public T[] TheList { get; set; }
        public int CurrentIndex { get; set; }
        public FixedSizeList(int listSize) { 
            Length = listSize;
            TheList = new T[listSize];
            CurrentIndex = 0;
        }

        public void Add(T value)
        {
            if (CurrentIndex == Length)
                throw new Exception("Exception: The Fixed Size List is full !!");
            TheList[CurrentIndex++] = value;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= Length)
                throw new Exception("Exception: Invalid Index");
            return TheList[index];
        }
    }
}
