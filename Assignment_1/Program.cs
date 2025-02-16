using System.Runtime.ConstrainedExecution;
using System.Threading;
using System.Xml.Linq;
using Assignment_1.CustomComparer;
using static Assignment_1.ListGenerator;
namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators

            #region 1. Find all products that are out of stock
            //Console.WriteLine("1. Find all products that are out of stock.\n");
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //var outOfStockProductsFluent = ProductList.Where(product => product.UnitsInStock == 0);
            //foreach (var product in outOfStockProductsFluent)
            //    Console.WriteLine(product);

            //Console.WriteLine("****************** Query Syntax ******************");
            //var outOfStockProductsQuery = from product in ProductList
            //                              where product.UnitsInStock == 0
            //                              select product;
            //foreach (var product in outOfStockProductsQuery)
            //    Console.WriteLine(product);


            #endregion


            #region 2.Find all products that are in stock and cost more than 3.00 per unit.

            //Console.WriteLine("2.Find all products that are in stock and cost more than 3.00 per unit.\n");

            //Console.WriteLine("****************** Fluent Syntax ******************");
            //var ProductsFluent = ProductList.Where(product => product.UnitsInStock > 0 && product.UnitPrice > 3.0m);
            //foreach (var product in ProductsFluent)
            //    Console.WriteLine(product);

            //Console.WriteLine("****************** Query Syntax ******************");
            //var ProductsQuery = from product in ProductList
            //                    where product.UnitsInStock > 0 && product.UnitPrice > 3.0M
            //                    select product;
            //foreach (var product in ProductsQuery)
            //    Console.WriteLine(product);

            #endregion


            #region 3.Returns digits whose name is shorter than their value.

            //Console.WriteLine("3.Returns digits whose name is shorter than their value.\n");

            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //var Digits = Arr.Where((name, index) => name.Length < index);
            //foreach (var digit in Digits)
            //    Console.WriteLine(digit);

            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name.
            //Console.WriteLine("1. Sort a list of products by name.\n");
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //var SortedProductsFluent = ProductList.OrderBy(product => product.ProductName);
            //foreach(var product in SortedProductsFluent)
            //    Console.WriteLine(product);
            //Console.WriteLine("\n\n****************** Query Syntax ******************");
            //var SortedProductsQuery = from product in ProductList
            //                          orderby product.ProductName
            //                          select product;
            //foreach (var product in SortedProductsQuery)
            //    Console.WriteLine(product);
            #endregion


            #region 2.Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //Console.WriteLine("2.Uses a custom comparer to do a case-insensitive sort of the words in an array.\n");
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var WordsInOrder = Arr.OrderBy(word => word, new CaseInsensitiveComparer());
            //Console.WriteLine(string.Join(" , ", WordsInOrder));
            #endregion


            #region 3. Sort a list of products by units in stock from highest to lowest.
            //Console.WriteLine("3. Sort a list of products by units in stock from highest to lowest.\n");
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //var ProductsInStockFluent = ProductList.OrderByDescending(product => product.UnitsInStock);
            //foreach (var product in ProductsInStockFluent)
            //    Console.WriteLine(product);
            //Console.WriteLine("\n\n****************** Query Syntax ******************");
            //var ProductsInStockQuery = from product in ProductList
            //                           orderby product.UnitsInStock descending
            //                           select product;
            //foreach (var product in ProductsInStockQuery)
            //    Console.WriteLine(product);
            #endregion


            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //Console.WriteLine("4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.\n");
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var OrderedWordsFluent = Arr.OrderBy(word => word)
            //                      .OrderBy(word => word.Length);
            //Console.WriteLine(string.Join(" , ", OrderedWordsFluent));
            //Console.WriteLine("\n\n****************** Query Syntax ******************");
            //var OrderedWordsQuery = from word in Arr
            //                        orderby word.Length, word
            //                        select word;
            //Console.WriteLine(string.Join(" , ", OrderedWordsQuery));
            #endregion


            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //Console.WriteLine("5. Sort first by-word length and then by a case-insensitive sort of the words in an array.\n");
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var OrderedWordsFluent = Arr.OrderBy(word => word, new CaseInsensitiveComparer())
            //                            .OrderBy(word => word.Length);
            //Console.WriteLine(string.Join(" , ", OrderedWordsFluent));

            //Console.WriteLine("\n\n****************** Query Syntax ******************");
            //var OrderedWordsQuery = from word in Arr
            //                        orderby word.Length, word
            //                        select word;
            //Console.WriteLine(string.Join(" , ", OrderedWordsQuery));

            #endregion


            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //Console.WriteLine("6. Sort a list of products, first by category, and then by unit price, from highest to lowest.");
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //var SortedProductsFluent = ProductList.OrderByDescending(product => product.UnitPrice)
            //                                      .OrderBy(product => product.Category);
            //foreach(var product in SortedProductsFluent)
            //    Console.WriteLine(product);
            //Console.WriteLine("\n\n****************** Query Syntax ******************");
            //var SortedProductsQuery = from product in ProductList
            //                          orderby product.Category, product.UnitPrice descending
            //                          select product;
            //foreach (var product in SortedProductsQuery)
            //    Console.WriteLine(product);

            #endregion


            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //Console.WriteLine("7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.\n");
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var OrderedWordsFluent = Arr.OrderByDescending(word => word, new CaseInsensitiveComparer())
            //                            .OrderBy(word => word.Length);
            //Console.WriteLine(string.Join(" , ", OrderedWordsFluent));
            //Console.WriteLine("\n\n****************** Query Syntax ******************");
            //var OrderedWordsQuery = from word in Arr
            //                        orderby word.Length, word descending
            //                        select word;
            //Console.WriteLine(string.Join(" , ", OrderedWordsQuery));

            #endregion


            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //Console.WriteLine("8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.\n");
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //IEnumerable<string> OrderedNumbers = Arr.Where(word => char.ToLower(word[1]) == 'i').Reverse();
            //foreach (var number in OrderedNumbers)
            //    Console.WriteLine(number);

            #endregion


            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.

            //Console.WriteLine("1. Return a sequence of just the names of a list of products.\n");
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //IEnumerable<string> ProductNamesFluent = ProductList.Select(product => product.ProductName);
            //Console.WriteLine(string.Join(" , ", ProductNamesFluent));
            //Console.WriteLine("****************** Query Syntax ******************");
            //var ProductNamesQuery = from product in ProductList
            //                        select product.ProductName;
            //Console.WriteLine(string.Join(" , ", ProductNamesQuery));

            #endregion


            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //Console.WriteLine("2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).\n");
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var UpperAndLowerCaseFluent = words.Select(word => new { upperCase = word.ToUpper(), lowerCase = word.ToLower() });
            //foreach (var word in UpperAndLowerCaseFluent)
            //    Console.WriteLine($"Uppercase: {word.upperCase} , Lowercase: {word.lowerCase}");
            //Console.WriteLine("****************** Query Syntax ******************");
            //var UpperAndLowerCaseQuery = from word in words
            //                             select new { upperCase = word.ToUpper(), lowerCase = word.ToLower() };
            //foreach (var word in UpperAndLowerCaseQuery)
            //    Console.WriteLine($"Uppercase: {word.upperCase} , Lowercase: {word.lowerCase}");
            #endregion


            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //Console.WriteLine("3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.\n");
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //var productsPropertiesFluent = ProductList.Select(product => new { price = product.UnitPrice, 
            //                                                             stock = product.UnitsInStock, 
            //                                                             name = product.ProductName});
            //foreach (var product in productsPropertiesFluent)
            //    Console.WriteLine($"Price: {product.price} , Stock: {product.stock} , Name: {product.name}");

            //Console.WriteLine("\n****************** Query Syntax ******************");
            //var productsPropertiesQuery = from product in ProductList
            //                              select new {
            //                                  price = product.UnitPrice,
            //                                  stock = product.UnitsInStock,
            //                                  name = product.ProductName
            //                              };
            //foreach (var product in productsPropertiesQuery)
            //    Console.WriteLine($"Price: {product.price} , Stock: {product.stock} , Name: {product.name}");
            #endregion


            #region 4. Determine if the value of int in an array match their position in the array.

            //Console.WriteLine("4. Determine if the value of int in an array match their position in the array.\n");
            //Console.WriteLine("Number: In-Place?");
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var isNumbersInLocation_1 = Arr.Select((number, index) => $"{number}: {number == index}");
            //foreach (var number in isNumbersInLocation_1)
            //    Console.WriteLine($"{number}");


            //Console.WriteLine("****************** Another Try ******************");
            //List<bool> isNumbersInLocation_2 = Arr.Select((number, index) => number == index).ToList();
            //for (int i = 0; i < Arr.Length; i++)
            //    Console.WriteLine($"{Arr[i]}: {isNumbersInLocation_2[i]}");


            //Console.WriteLine("****************** Another Try ******************");
            //var isNumbersInLocation_3 = Arr.Select((number, index) => new { number, isEqual = number == index });
            //foreach (var number in isNumbersInLocation_3)
            //    Console.WriteLine($"{number.number}: {number.isEqual}");

            #endregion


            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.

            //Console.WriteLine("5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.\n");
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //Console.WriteLine("Pairs Where a < b:");
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //var pairsFluent = numbersA.SelectMany(a => numbersB.Where(b => a < b), (a, b) => new { a, b });
            //foreach (var pair in pairsFluent)
            //    Console.WriteLine($"{pair.a} is less than {pair.b}");
            //Console.WriteLine("****************** Query Syntax ******************");
            //var pairsQuery = from num1 in numbersA
            //                 from num2 in numbersB
            //                 where num1 < num2
            //                 select new { num1, num2 };
            //foreach (var pair in pairsQuery)
            //    Console.WriteLine($"{pair.num1} is less than {pair.num2}");

            #endregion


            #region 6. Select all orders where the order total is less than 500.00.

            //Console.WriteLine("6. Select all orders where the order total is less than 500.00.\n");
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //IEnumerable<Order> OrdersLessThan500Fluent = CustomerList.SelectMany(customer => customer.Orders.Where(order => order.Total < 500), 
            //                                                (customer, order) => order);
            //foreach (var order in OrdersLessThan500Fluent)
            //    Console.WriteLine(order);
            //Console.WriteLine("\n****************** Query Syntax ******************");
            //var OrdersLessThan500Query = from customer in CustomerList
            //                             from order in customer.Orders
            //                             where order.Total < 500
            //                             select order;
            //foreach (var order in OrdersLessThan500Query)
            //    Console.WriteLine(order);

            #endregion


            #region 7. Select all orders where the order was made in 1998 or later.
            //Console.WriteLine("7. Select all orders where the order was made in 1998 or later.\n");
            //Console.WriteLine("****************** Fluent Syntax ******************");
            //IEnumerable<Order> OrdersAbove1998Fluent = CustomerList.SelectMany(customer => customer.Orders.Where(order => order.OrderDate.Year >= 1998),
            //                                              (customer, order) => order);
            //foreach (var order in OrdersAbove1998Fluent)
            //    Console.WriteLine(order);

            //Console.WriteLine("\n****************** Query Syntax ******************");
            //var OrdersAbove1998Query = from customer in CustomerList
            //                           from order in customer.Orders
            //                           where order.OrderDate.Year >= 1998
            //                           select order;
            //foreach (var order in OrdersAbove1998Query)
            //    Console.WriteLine(order);
            #endregion

            #endregion

        }
    }
}
