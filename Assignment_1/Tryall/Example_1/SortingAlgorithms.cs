namespace C__Session_12.Delegate_Example_2
{
    public delegate bool CompareSortingDelegate(int x, int y);
    public static class SortingAlgorithms
    {

        public static void BubbleSortAsc(int[] arr)
        {
            if (arr?.Length == 0) return; // equavilent to --> arr == null && arr.Length == 0

            for (int i = 0; i < arr.Length; i++)
            {
                bool isSwap = false; // for optimization
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        isSwap = true;
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
                if (!isSwap) // for optimization
                    break;
            }
        }

        private static void Swap(ref int x, ref int y) // private as it won't be used outside the class --> applying the Abstraction
        {
            (x, y) = (y, x);
        }

        public static void BubbleSortDesc(int[] arr)
        {
            if (arr?.Length == 0) return; // equavilent to --> arr == null && arr.Length == 0

            for (int i = 0; i < arr.Length; i++)
            {
                bool isSwap = false; // for optimization
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        isSwap = true;
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
                if (!isSwap) // for optimization
                    break;
            }
        }

        public static void BubbleSortUsingDelegateWithoutRepeating(int[] arr, CompareSortingDelegate compareSortingDelegate)
        {
            if (arr?.Length == 0 || compareSortingDelegate is null) return; // equavilent to --> arr == null && arr.Length == 0

            for (int i = 0; i < arr.Length; i++)
            {
                bool isSwap = false; // for optimization
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    //if (arr[j] < arr[j + 1])
                    //if (compareSortingDelegate?.Invoke(arr[j], arr[j + 1]) ?? false) // Take care --> The compiler treats delegate as a class so it may be null
                    // This above -> ? .. ?? false -> isnot efficient as we should prevent it if the delegate is null from begining.
                    if (compareSortingDelegate(arr[j], arr[j + 1])) // it can work without Invoke --> Not Recommended
                    {
                        isSwap = true;
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
                if (!isSwap) // for optimization
                    break;
            }
        }


        public static void BubbleSortUsingBuiltInDelegate(int[] arr, Func<int, int, bool> compareSortingDelegate)
        {
            if (arr?.Length == 0 || compareSortingDelegate is null) return; // equavilent to --> arr == null && arr.Length == 0

            for (int i = 0; i < arr.Length; i++)
            {
                bool isSwap = false; // for optimization
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    //if (arr[j] < arr[j + 1])
                    //if (compareSortingDelegate?.Invoke(arr[j], arr[j + 1]) ?? false) // Take care --> The compiler treats delegate as a class so it may be null
                    // This above -> ? .. ?? false -> isnot efficient as we should prevent it if the delegate is null from begining.
                    if (compareSortingDelegate(arr[j], arr[j + 1])) // it can work without Invoke --> Not Recommended
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
