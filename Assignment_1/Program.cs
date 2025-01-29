using System.Collections;
using System.Collections.Generic;
using Assignment_1.Optimised_BubleSort;
using Assignment_1.Q2__Range;
using Assignment_1.FixedSizeList;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1) Optimised Bubble Sort algorithm
            /*
             * 1. The Bubble Sort algorithm has a time complexity of O(n^2) in its worst
                    and average cases, which makes it inefficient for large datasets. How we
                    can optimise the Bubble Sort algorithm
                    And implement the code of this optimised bubble sort algorithm 
             */

            //// 1) Problem 1 => The algorithm will continue looping till end despite the array is sorted early
            //// 2) Problem 2 => at each external loop 1 number is getting sorted, so no need to compare it once again -> instead of n-1 we'll use n-1-i

            //int[] numbers = { 7, 8, 2, 4, 9, 6, 3, 1, 5 };
            //Console.WriteLine("================== Before Sorting ==================");
            //foreach (int number in numbers) {
            //    Console.Write($"{number} ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("================== After Sorting ==================");
            //BubbleSortOptimised<int>.BubbleSort(numbers);
            //foreach (int number in numbers)
            //{
            //    Console.Write($"{number} ");
            //}
            //Console.WriteLine();


            //Employee[] employees =
            //{
            //    new Employee() { Id = 40, Name = "Sharaf", Salary = 9_000 },
            //    new Employee() { Id = 20, Name = "Omar", Salary = 2_000 },
            //    new Employee() { Id = 30, Name = "Omnia", Salary = 5_000 },
            //    new Employee() { Id = 10, Name = "Ahmed", Salary = 8_000 },
            //};

            //Console.WriteLine("========================== Before Sorting ==========================");
            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}

            //Console.WriteLine("========================== After Sorting By Id ==========================");
            //BubbleSortOptimised<Employee>.BubbleSort(employees);
            //foreach (Employee emp in employees)
            //{
            //    Console.WriteLine(emp);
            //}



            #endregion
            

            #region 2) Range<T> class

            /*
                2. create a generic Range<T> class that represents a range of values from a
                    minimum value to a maximum value. The range should support basic
                    operations such as checking if a value is within the range and
                    determining the length of the range.
                    Requirements:
                    1. Create a generic class named Range<T> where T represents the type
                    of values.
                    2. Implement a constructor that takes the minimum and maximum
                    values to define the range.
                    3. Implement a method IsInRange(T value) that returns true if the given
                    value is within the range, otherwise false.
                    4. Implement a method Length() that returns the length of the range
                    (the difference between the maximum and minimum values).
                    5. Note: You can assume that the type T used in the Range<T> class
                    implements the IComparable<T> interface to allow for comparisons. 

             */


            //Range<int> RangeOfNumbers = new Range<int>(1, 10); // I assume 1 and 10 are included within the range
            //Console.WriteLine($"Range Length: {RangeOfNumbers.Length()}");
            //Console.WriteLine($"Is 10 in range: " + (RangeOfNumbers.IsInRange(10) ? "Yes" : "No" ));
            //Console.WriteLine($"Is 11 in range: " + (RangeOfNumbers.IsInRange(11) ? "Yes" : "No"));


            ////---------------> Employee


            //Range<Employee> RangeOfEmployees = new Range<Employee>(
            //        new Employee() { Id = 10, Name = "Sharaf", Salary = 9_000 },
            //        new Employee() { Id = 40, Name = "Ahmed", Salary = 10_000 }
            //);

            //Console.WriteLine($"Range Length: {RangeOfEmployees.Length()}"); // assuming 10 included =>> 31 Employee

            //Employee Sama = new Employee() { Id = 30, Name = "Sama", Salary = 4_000 };
            //Console.WriteLine($"Is {Sama} in range: " + (RangeOfEmployees.IsInRange(Sama) ? "Yes" : "No"));

            //Employee Khaled = new Employee() { Id = 44, Name = "Khaled", Salary = 32_000 };
            //Console.WriteLine($"Is Employee {Khaled} in range: " + (RangeOfEmployees.IsInRange(Khaled) ? "Yes" : "No"));



            #endregion


            #region 3) Reverse an ArrayList

            /*
             3) You are given an ArrayList containing a sequence of elements. try to
                reverse the order of elements in the ArrayList in-place(in the same
                arrayList) without using the built-in Reverse. Implement a function that
                takes the ArrayList as input and modifies it to have the reversed order of
                elements.
             */

            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Console.WriteLine("=================== Before Reversing ===================");

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.Write($"{arrayList[i]} ");
            //}
            //Console.WriteLine();

            //Console.WriteLine("=================== After Reversing ===================");

            //MyReverse(arrayList);

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.Write($"{arrayList[i]} ");
            //}
            //Console.WriteLine();

            #endregion


            #region 4) Get Evens
            /*
                4) You are given a list of integers. Your task is to find and return a new list
                containing only the even numbers from the given list.
            */
            // // List is prefered than ArrayList Because of UnBoxing that will add overhead.

            //List<int> listOFNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //List<int> theEvens = GetEvens(listOFNumbers);

            //for (int i = 0; i < theEvens.Count; i++)
            //{
            //    Console.Write($"{theEvens[i]} ");
            //}


            #endregion


            #region 5) Custom FixedSizeList<T>

            /*
             5. implement a custom list called FixedSizeList<T> with a predetermined
                capacity. This list should not allow more elements than its capacity and
                should provide clear messages if one tries to exceed it or access invalid indices.
                Requirements:
                1. Create a generic class named FixedSizeList<T>.
                2. Implement a constructor that takes the fixed capacity of the list as a
                parameter.
                3. Implement an Add method that adds an element to the list, but
                throws an exception if the list is already full.
                4. Implement a Get method that retrieves an element at a specific index
                in the list but throws an exception for invalid indices.
            */

            //FixedSizeList<int> listOfNumbers = new FixedSizeList<int>(3);

            //listOfNumbers.Add(11);
            //listOfNumbers.Add(22);
            //listOfNumbers.Add(33);
            //for (int i = 0; i < listOfNumbers.Length; i++) {
            //    Console.WriteLine($"index: {i} -> value: {listOfNumbers.Get(i)}");
            //}

            //try
            //{
            //    listOfNumbers.Add(44);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    listOfNumbers.Get(3);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //// --------------------------> List of Employees
            //Console.WriteLine("\n========================== List of Employees ==========================\n");

            //FixedSizeList<Employee> listOfEmployees = new FixedSizeList<Employee>(3);

            //listOfEmployees.Add(new Employee() { Id = 10, Name = "Sharaf", Salary = 9_000 });
            //listOfEmployees.Add(new Employee() { Id = 30, Name = "Ahmed", Salary = 1_0000 });
            //listOfEmployees.Add(new Employee() { Id = 40, Name = "Mona", Salary = 11_000 });

            //for (int i = 0; i < listOfEmployees.Length; i++)
            //{
            //    Console.WriteLine($"index: {i} -> value: {listOfEmployees.Get(i)}");
            //}

            //try
            //{
            //    listOfEmployees.Add(new Employee() { Id = 22, Name = "Said", Salary =2_000 });
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //try
            //{
            //    listOfEmployees.Get(3);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}




            #endregion


            #region 6) first non-repeated character

            /*
             6. Given a string, find the first non-repeated character in it and return its
                index. If there is no such character, return -1. Hint you can use dictionary
            */

            //string str = "abczxycbarx";
            //int index = GetTheFirstNonRepeatedChar(str);

            //Console.WriteLine($"Char is {str[index]} and at index {index}"); // it's z at index 3

            //str = "abzzxyycbarx";
            //index = GetTheFirstNonRepeatedChar(str);

            //Console.WriteLine($"Char is {str[index]} and at index {index}"); // it's c at index 7


            #endregion


        }
        static void MyReverse(ArrayList Arr)
        {
            int n = Arr.Count;
            for (int i = 0; i < n/2; i++) { // 10 : 0 to 4 | 9 : 0 to 4
                (Arr[i], Arr[n - i - 1]) = (Arr[n - i - 1], Arr[i]);
            }
        }

        static List<int> GetEvens(List<int> Arr)
        {
            if (Arr == null || Arr.Count == 0)
                return Arr;

            int n = Arr.Count;
            List<int> theRetEvens = new List<int>();
            for (int i = 0; i < n; i++) {
                if (Arr[i] % 2 == 0)
                {
                    theRetEvens.Add(Arr[i]);
                }
            }

            return theRetEvens;
        }

        static int GetTheFirstNonRepeatedChar(string str)
        {
            Dictionary<char, int[]> frequency = new Dictionary<char, int[]>();

            for (int i = 0; i < str.Length; i++)
            {
                if (frequency.TryGetValue(str[i], out int[] value))
                {
                    value[1]++;
                }
                else
                {
                    frequency[str[i]] = new int[] { i, 1};
                }
            }

            foreach (KeyValuePair<char, int[]> charFreq in frequency)
            {
                if (charFreq.Value[1] == 1)
                {
                    return charFreq.Value[0];
                }
            }

            return -1;
        }
    }
}
