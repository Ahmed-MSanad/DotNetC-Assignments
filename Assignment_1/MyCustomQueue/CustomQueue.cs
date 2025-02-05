using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.MyCustomQueue
{
    public class CustomQueue
    {
        private object[] Array { get; set; }
        private int Capacity { get; set; }
        private int Count { get; set; }

        public CustomQueue()
        {
            Capacity = 4;
            Count = 0;
            Array = new object[Capacity];
        }

        private void ExpandCapacity()
        {
            Capacity *= 2;
            object[] newLocation = new object[Capacity];
            for (int i = 0; i < Capacity; i++)
            {
                newLocation[i] = Array[i];
            }
            Array = newLocation;
        }

        public void Enqueue(object value)
        {
            if (Capacity == Count)
                ExpandCapacity();
            Array[Count++] = value;
        }

        public void printQueue()
        {
            for (int i = 0; i < Count; i++)
                Console.Write($"{Array[i]}, ");
            Console.WriteLine();
        }
    }
}
