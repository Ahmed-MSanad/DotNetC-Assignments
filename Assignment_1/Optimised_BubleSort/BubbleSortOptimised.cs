using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Optimised_BubleSort
{
    public class BubbleSortOptimised<T> where T : IComparable
    {

        public static void Swap(ref T x, ref T y)
        {
            (x, y) = (y, x);
        }
        public static void BubbleSort(T[] Arr)
        {
            if (Arr == null || Arr.Length == 0) return;

            for (int i = 0; i < Arr?.Length; i++) {
                bool isSwapHappen = false;
                for(int j = 0; j < Arr?.Length - 1 - i; j++) // 1st optimization -> don't compare to the largest sorted numbers as they are already sorted.
                {
                    if (Arr[j].CompareTo(Arr[j + 1]) == 1)
                    {
                        Swap(ref Arr[j], ref Arr[j+1]);
                        isSwapHappen = true;
                    }
                }
                if (!isSwapHappen) // 2nd optimization -> if No Swap has occured in last external loop then that is indicate the array is already sorted.
                {
                    break;
                }
            }
        }
    }
}
