using System.Collections.Generic;
using Assignment_1._2._3CustomComparerToMatchWords;
using C__Session_18;
using static C__Session_18.ListGenerator;
namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ – Partitioning Operators

            #region  1. Get the first 3 orders from customers in Washington

            //var first3OrdersFluent = CustomerList.Select(customer => new { customerName = customer.CustomerName, orders = customer.Orders.Take(3) });
            //foreach(var customer in first3OrdersFluent)
            //{
            //    Console.WriteLine($"First 3 orders of the customer => {customer.customerName}: ");
            //    foreach(var order in customer.orders)
            //    {
            //        Console.WriteLine($"{order}");
            //    }
            //    Console.WriteLine(new string('-', 100));
            //}

            // // // ------------ ----------------- Query Syntax --> Take -> top in sql server -> but not avaliable here.

            //var first3OrdersQuery = from customer in CustomerList
            //                        select new { customerName = customer.CustomerName, orders = customer.Orders.Take(3) };

            //foreach (var customer in first3OrdersQuery)
            //{
            //    Console.WriteLine($"First 3 orders of the customer => {customer.customerName}: ");
            //    foreach (var order in customer.orders)
            //    {
            //        Console.WriteLine($"{order}");
            //    }
            //    Console.WriteLine(new string('-', 100));
            //}


            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.

            //var customerOrdersButTheFirst2 = CustomerList.Select(customer => new { customerName = customer.CustomerName, orders = customer.Orders.Skip(2) });
            //foreach (var customer in customerOrdersButTheFirst2)
            //{
            //    Console.WriteLine($"First 3 orders of the customer => {customer.customerName}: ");
            //    foreach (var order in customer.orders)
            //    {
            //        Console.WriteLine($"{order}");
            //    }
            //    Console.WriteLine(new string('-', 100));
            //}


            // // ----------------- -------------------- Query syntax


            //var customerOrdersButTheFirst2Query = from customer in CustomerList
            //                                 select new
            //                                 {
            //                                     customerName = customer.CustomerName,
            //                                     orders = customer.Orders.Skip(2)
            //                                 };
            //foreach (var customer in customerOrdersButTheFirst2Query)
            //{
            //    Console.WriteLine($"First 3 orders of the customer => {customer.customerName}: ");
            //    foreach (var order in customer.orders)
            //    {
            //        Console.WriteLine($"{order}");
            //    }
            //    Console.WriteLine(new string('-', 100));
            //}



            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int[] valuesGreaterThanIndex = numbers.TakeWhile((number, index) => number >= index).ToArray();

            //Console.WriteLine(string.Join(" , ", valuesGreaterThanIndex));

            #endregion

            #region 4. Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var firstNumbersStartWithDivisiableBy3 = numbers.SkipWhile(number => number % 3 != 0);

            //Console.WriteLine(string.Join(" , ", firstNumbersStartWithDivisiableBy3));

            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //IEnumerable<int> firstNumbersStartWithLessThanPos = numbers.SkipWhile((number, index) => number > index);

            //Console.WriteLine(string.Join(" , ", firstNumbersStartWithLessThanPos));

            #endregion

            #endregion

            #region LINQ – Grouping Operators

            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var partitioningOfTheNumbersFluent = numbers.GroupBy(number => number % 5);

            //foreach (var reminder in partitioningOfTheNumbersFluent)
            //{
            //    Console.WriteLine($"Numbers With a reminder of {reminder.Key} when divided by 5: ");

            //    Console.WriteLine(string.Join('\n', reminder));
            //}


            // ---------------- ------------------ ---------------- Query:


            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var partitioningOfTheNumbersQuery = from number in numbers
            //                                    group number by (number % 5);

            //foreach (var reminder in partitioningOfTheNumbersQuery)
            //{
            //    Console.WriteLine($"Numbers With a reminder of {reminder.Key} when divided by 5: ");

            //    Console.WriteLine(string.Join('\n', reminder));
            //}


            #endregion

            #region 2. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

            //List<string> listOfWords = new List<string>();

            // ----------------------------------------------------------------- Reading from a file
            //StreamReader s = new StreamReader("dictionary_english.txt");

            //string line = s.ReadLine();

            //while(line != null)
            //{
            //    listOfWords.Add(line);
            //    line = s.ReadLine();
            //}

            //s.Close();
            // ----------------------------------------------------------------- maximum of 26 group -> 26 characters

            //var groupFirstLetterFluent = listOfWords.GroupBy(word => word[0]);

            //foreach(var group in groupFirstLetterFluent)
            //{
            //    Console.WriteLine($"\nWords start with {group.Key} are: ");
            //    Console.WriteLine(new string('-', 100));
            //    Console.WriteLine(string.Join(" , ", group));
            //    Console.WriteLine();
            //}


            // ----------------------------------------------------------------- Query Syntax:


            //var groupFirstLetterQuery = from word in listOfWords
            //                            group word by word[0];
            //foreach (var group in groupFirstLetterQuery)
            //{
            //    Console.WriteLine($"\nWords start with {group.Key} are: ");
            //    Console.WriteLine(new string('-', 100));
            //    Console.WriteLine(string.Join(" , ", group));
            //    Console.WriteLine();
            //}


            #endregion

            #region 3. Consider this Array as an Input then Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //String[] Arr = { "from", "salt", "earn", " last", "near", "form" };

            //var wordsWithSameCharacters = Arr.GroupBy(word => word, new WordsWithSameCharacters());

            //foreach (var word in wordsWithSameCharacters)
            //{
            //    Console.WriteLine($"Words that are consists of the same Characters: ");
            //    Console.WriteLine(string.Join(" , ", word));
            //}

            #endregion

            #endregion
        }
    }
}
