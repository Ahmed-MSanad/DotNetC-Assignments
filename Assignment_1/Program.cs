using System.Collections;
using Assignment_1.MyCustomQueue;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment

            #region 1.Given an array consists of numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than X.
            // // // // // O(qlog(n)) : where q number of the quiers and n is number of numbers

            //Console.WriteLine("Enter Array Size: ");
            //int size;
            //while (!int.TryParse(Console.ReadLine(), out size))
            //{
            //    Console.WriteLine("Enter correct size first, ...!!!");
            //}


            //Console.WriteLine("Number of Quiers: ");
            //int quiersCount;
            //while (!int.TryParse(Console.ReadLine(), out quiersCount))
            //{
            //    Console.WriteLine("Enter correct Number of Quiers first, ...!!!");
            //}


            //Console.WriteLine("List of Numbers in 1 line Please: ");
            //int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            //Array.Sort(numbers);

            //for (int i = 0; i < quiersCount; i++)
            //{
            //    Console.WriteLine($"Enter Query number {i + 1}: ");
            //    int number = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"{number} has {GetCountGreaterThan(number, size, numbers)} greater than it.");
            //}

            #endregion

            #region 2. Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //Console.WriteLine("Size Please: ");
            //int size;
            //while (!int.TryParse(Console.ReadLine(), out size))
            //{
            //    Console.WriteLine("Enter correct size first, ...!!!");
            //}

            //Console.WriteLine("List of numbers in one line please seperated by space: ");
            //string input = Console.ReadLine();

            //int[] numbers = input.Split(" ").Select(int.Parse).ToArray();

            //Stack<int> myStack = new Stack<int>(numbers);

            //for (int i = 0; i < size && myStack.Peek() == numbers[i] ; i++) myStack.Pop();

            //Console.WriteLine(myStack.Count == 0 ? "Yes" : "No");

            #endregion

            #region 3. Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> numbers = new Queue<int>(new int[] { 1, 2, 3, 4, 5, 6, 7 });

            //numbers = ReverseNumbers(numbers);

            //foreach(int number in numbers)
            //    Console.Write($"{number}, ");

            #endregion

            #region 4. Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //string parentheses = "[()]{}";

            //Console.WriteLine(CheckParentheses(parentheses) ? "Balanced" : "Not Balanced");

            //parentheses = "[(()]{}";

            //Console.WriteLine(CheckParentheses(parentheses) ? "Balanced" : "Not Balanced");

            //parentheses = "[(()]){}";

            //Console.WriteLine(CheckParentheses(parentheses) ? "Balanced" : "Not Balanced");

            #endregion

            #region 5. Given an array, implement a function to remove duplicate elements from an array.

            //int[] numbers = { 1, 1, 2, 3, 3, 4, 4, 3, 2, 5, 4, 2, 4, 6, 5, 3 };

            //numbers = RemoveDuplicates(numbers);

            //foreach (int number in numbers)
            //    Console.Write($"{number}, ");
            //Console.WriteLine();

            #endregion

            #region 6.Given an array list , implement a function to remove all odd numbers from it.

            //ArrayList numbers = new ArrayList(new[] { 1, 2, 3, 4, 5, 6 ,7 ,8 ,9 ,10});

            //ArrayList numbersWithoutOdds = new ArrayList(RemoveOdds(numbers));

            //foreach (object i in numbersWithoutOdds)
            //    Console.Write($"{i}, ");
            //Console.WriteLine();

            #endregion

            #region 7. Implement a queue that can hold different data types. And insert the following data: queue.Enqueue(1) queue.Enqueue(“Apple”) queue.Enqueue(5.28)

            //CustomQueue customQueue = new CustomQueue();

            //customQueue.Enqueue(1);
            //customQueue.Enqueue("Apple");
            //customQueue.Enqueue(5.28);

            //customQueue.printQueue();

            #endregion

            #region 8. Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”). Note : take the target as input from the user

            //Console.WriteLine("Enter the target to start searching.... ");

            //int userTarget;

            //while (!int.TryParse(Console.ReadLine(), out userTarget))
            //{
            //    Console.WriteLine("Enter correct target first, ...!!!");
            //}

            //Console.WriteLine(CheckTarget(userTarget));


            #endregion

            #region 9. Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            //int ArraySize_1, ArraySize_2;

            //Console.WriteLine("Enter size of first array: ");

            //while (!int.TryParse(Console.ReadLine(), out ArraySize_1))
            //{
            //    Console.WriteLine("Enter correct size first, ...!!!");
            //}

            //Console.WriteLine("Enter size of second array: ");

            //while (!int.TryParse(Console.ReadLine(), out ArraySize_2))
            //{
            //    Console.WriteLine("Enter correct size first, ...!!!");
            //}

            //Console.WriteLine("Please, Enter first array elements in 1 line..");
            //int[] arr_1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            //Console.WriteLine("Please, Enter second array elements in 1 line..");
            //int[] arr_2 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            //Dictionary<int, int> numberFrequancyPairs_1 = new Dictionary<int, int>();

            //foreach (int i in arr_1)
            //{
            //    if(numberFrequancyPairs_1.ContainsKey(i))
            //        numberFrequancyPairs_1[i]++;
            //    else
            //        numberFrequancyPairs_1[i] = 1;
            //}


            //Dictionary<int, int> numberFrequancyPairs_2 = new Dictionary<int, int>();

            //foreach (int i in arr_2)
            //{
            //    if (numberFrequancyPairs_2.ContainsKey(i))
            //        numberFrequancyPairs_2[i]++;
            //    else
            //        numberFrequancyPairs_2[i] = 1;
            //}

            //foreach(int key in numberFrequancyPairs_1.Keys)
            //{
            //    if (numberFrequancyPairs_2.ContainsKey(key))
            //    {
            //        int size = Math.Min(numberFrequancyPairs_1[key], numberFrequancyPairs_2[key]);
            //        for (int i = 0; i < size; i++)
            //            Console.Write($"{key}, ");
            //    }
            //}


            #endregion

            #region 10. Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

            //ArrayList listOfIntegers = new ArrayList(new int[] { 1, 2, 3, 7, 5 });

            //int userTargetSum = 12; // 15

            //int p1 = 0, p2 = 0, sum = 0;

            //while(p2 < listOfIntegers.Count)
            //{
            //    if(sum == userTargetSum)
            //    {
            //        break;
            //    }
            //    else if (sum < userTargetSum)
            //    {
            //        sum += (int)listOfIntegers[p2];
            //        p2++;
            //    }
            //    else
            //    {
            //        sum -= (int)listOfIntegers[p1];
            //        p1++;
            //    }
            //}
            //if(sum == userTargetSum)
            //{
            //    for(int i = p1; i < p2; i++)
            //        Console.Write($"{listOfIntegers[i]} ");
            //    Console.WriteLine();
            //}
            //else if(sum < userTargetSum)
            //{
            //    Console.WriteLine("NOT Found");
            //}
            //else
            //{
            //    bool found = false;
            //    while (p1 < listOfIntegers.Count)
            //    {
            //        sum -= (int)listOfIntegers[p1++];
            //        if (sum == userTargetSum)
            //        {
            //            found = true;
            //            break;
            //        }
            //    }
            //    if (found)
            //    {
            //        for (int j = p1; j < listOfIntegers.Count; j++)
            //            Console.Write($"{listOfIntegers[j]} ");
            //        Console.WriteLine();
            //    }
            //}

            #endregion

            #region 11. Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order

            //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });

            //int k = 3;

            //Stack<int> stack = new Stack<int>();

            //while (k > 0)
            //{
            //    stack.Push(queue.Dequeue());
            //    k--;
            //}
            //Queue<int> tempQueue = new Queue<int>(queue);
            //while(queue.Count > 0)
            //{
            //    queue.Dequeue();
            //}
            //while(stack.Count > 0)
            //{
            //    queue.Enqueue(stack.Pop());
            //}
            //while (tempQueue.Count > 0)
            //{
            //    queue.Enqueue(tempQueue.Dequeue());
            //}

            //foreach (int i in queue)
            //    Console.Write($"{i} ");
            //Console.WriteLine();

            #endregion

            #endregion


        }
        public static int GetCountGreaterThan(int value, int size, int[] numbers)
        {
            int l = 0, r = size - 1, mid;
            while (r >= l)
            {
                mid = (r + l) / 2;
                if (numbers[mid] > value)
                    r = mid - 1;
                else
                    l = mid + 1;
            }
            return (size - l);
        }

        public static Queue<int> ReverseNumbers(Queue<int> numbers)
        {
            Stack<int> reverseNumbers = new Stack<int>(numbers);
            return new Queue<int>(reverseNumbers);
        }

        public static bool CheckParentheses(string parentheses)
        {
            Stack<char> st = new Stack<char>();

            foreach (char ch in parentheses)
            {
                if (ch == '{' || ch == '(' || ch == '[')
                    st.Push(ch);
                else if ((ch == '}' && st.Peek() == '{') || (ch == ')' && st.Peek() == '(') || (ch == ']' && st.Peek() == '['))
                    st.Pop();
                else
                    return false;
            }

            return st.Count == 0;
        }

        public static int[] RemoveDuplicates(int[] elements)
        {
            HashSet<int> hashset = new HashSet<int>(elements);

            elements = hashset.ToArray();

            return elements;
        }

        public static ArrayList RemoveOdds(ArrayList numbers)
        {
            ArrayList withoutOdds = new ArrayList(numbers);
            foreach (object number in numbers)
            {
                if (((int)number % 2) != 0)
                    withoutOdds.Remove(number);
            }
            return withoutOdds;
        }

        public static string CheckTarget(int target)
        {
            Stack<int> randomNumbers = new Stack<int>(new int[] { 2, 4, 6, 8, 1, 3, 5, 9, 11, 13, 15 });

            Console.WriteLine("Searching in numbers ..... ");
            foreach (int i in randomNumbers)
                Console.Write($"{i}, ");
            Console.WriteLine();

            bool isFound = false;
            int count = 0;
            while (randomNumbers.Count > 0)
            {
                isFound = randomNumbers.Peek() == target;
                if (isFound)
                    break;
                randomNumbers.Pop();
                count++;
            }

            if (isFound)
                return $"Target was found successfully and the count = {count}";
            else
                return $"Target was not found";
        }

    }
}
