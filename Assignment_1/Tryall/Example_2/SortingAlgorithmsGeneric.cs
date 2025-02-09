using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Session_12.Delegate_Example_2_With_Generics
{
    //public delegate bool CompareTypesGenericDelegate<D>(D x, D y); // Now it points to a function that receives 2 parameters of same type and return bool

    //public delegate TResult CompareTypesGenericDelegate<D1, D2, TResult>(TResult x, D2 y); // to stop this happend -> in, out :

    public delegate TResult CompareTypesGenericDelegate<in D1, in D2, out TResult>(D1 x, D2 y);

    public static class SortingAlgorithmsGeneric<T>
    {

        public static void BubbleSort(T[] arr, CompareTypesGenericDelegate<T, T, bool> compareTypesGenericDelegate)
        {
            if (arr?.Length == 0 || compareTypesGenericDelegate is null) return; // equavilent to --> arr == null && arr.Length == 0

            for (int i = 0; i < arr.Length; i++)
            {
                bool isSwap = false; // for optimization
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (compareTypesGenericDelegate.Invoke(arr[j], arr[j + 1]))
                    {
                        isSwap = true;
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
                if (!isSwap) // for optimization
                    break;
            }
        }

        private static void Swap(ref T x, ref T y) // private as it won't be used outside the class --> applying the Abstraction
        {
            (x, y) = (y, x);
        }

        public static void BubbleSortUsingBuiltInDelegate(T[] arr, Func<T, T, bool> compareTypesGenericDelegate)
        {
            if (arr?.Length == 0 || compareTypesGenericDelegate is null) return; // equavilent to --> arr == null && arr.Length == 0

            for (int i = 0; i < arr.Length; i++)
            {
                bool isSwap = false; // for optimization
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (compareTypesGenericDelegate.Invoke(arr[j], arr[j + 1]))
                    {
                        isSwap = true;
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
                if (!isSwap) // for optimization
                    break;
            }
        }

    }
}
