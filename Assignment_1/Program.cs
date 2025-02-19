using System.Collections.Generic;
using C__Session_17;
using static C__Session_17.ListGenerator;
using System.IO;
namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Element Operators

            #region 1. Get first Product out of Stock

            //Product firstProductOutOfStock = ProductList.FirstOrDefault(product => product.UnitsInStock == 0, new Product());
            //Console.WriteLine(firstProductOutOfStock);

            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //Product? firstProductWithPriceAbove1000 = ProductList.FirstOrDefault(product => product.UnitPrice > 1000);
            //Console.WriteLine(firstProductWithPriceAbove1000); // null

            #endregion

            #region 3. Retrieve the second number greater than 5

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int? secondNumberAbove5 = Arr.Where(number => number > 5)
            //                            .ElementAtOrDefault(1);
            //Console.WriteLine(secondNumberAbove5);

            #endregion

            #endregion

            #region Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int numberOfOdds = Arr.Count(n => n%2 != 0);

            //Console.WriteLine($"Number of Odd Numbers is ==> {numberOfOdds}");


            #endregion

            #region 2. Return a list of customers and how many orders each has.

            //var customersAndOrders = CustomerList.Select(c => new { Name = c.CustomerName, OrderCount = c.Orders.Length });

            //foreach (var customer in customersAndOrders)
            //{
            //    Console.WriteLine($"Customer Name: {customer.Name}, Order Count: {customer.OrderCount}");
            //}

            #endregion

            #region 3. Return a list of categories and how many products each has

            //var categoriesAndProductCount = ProductList.GroupBy(product => product.Category)
            //                                           .Select(groupOfProducts => new { CategoryName = groupOfProducts.Key, ProductCount = groupOfProducts.Count() });
            //foreach(var category in categoriesAndProductCount)
            //{
            //    Console.WriteLine($"Category: {category.CategoryName}, Product Count: {category.ProductCount}");
            //}

            #endregion

            #region 4. Get the total of the numbers in an array.

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int total = Arr.Sum();

            //Console.WriteLine($"Total Of The Numbers is ==> {total}");

            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First)

            //string[] Words = ReadFile("dictionary_english.txt");
            //int totalNumberOfChar = Words.Sum(word => word.Length);
            //Console.WriteLine($"Total number of characters of all words in dictionary_english.txt ==> {totalNumberOfChar}");

            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Words = ReadFile("dictionary_english.txt");

            //int lengthOfMinWord = Words.MinBy(word => word.Count())?.Length ?? 0;
            //Console.WriteLine($"The length of the shortest word in dictionary_english.txt ==> {lengthOfMinWord}");

            //// // OR

            //int lengthOfMinWord_1 = Words.Min(word => word.Count());
            //Console.WriteLine($"The length of the shortest word in dictionary_english.txt ==> {lengthOfMinWord_1}");

            //// // OR

            //string? minWordLength_2 = Words.MinBy(word => word.Count());
            //Console.WriteLine($"The Word \"{minWordLength_2}\" has the shortest length in dictionary_english.txt ==> {minWordLength_2?.Length}");

            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Words = ReadFile("dictionary_english.txt");

            //int lengthOfMaxWord = Words.MaxBy(word => word.Count())?.Length ?? 0;
            //Console.WriteLine($"The length of the longest word in dictionary_english.txt ==> {lengthOfMaxWord}");

            //// // OR

            //int lengthOfMaxWord_1 = Words.Max(word => word.Count());
            //Console.WriteLine($"The length of the longest word in dictionary_english.txt ==> {lengthOfMaxWord_1}");

            //// // OR

            //string? maxWordLength_2 = Words.MaxBy(word => word.Count());
            //Console.WriteLine($"The Word \"{maxWordLength_2}\" has the longest length in dictionary_english.txt ==> {maxWordLength_2?.Length}");

            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] Words = ReadFile("dictionary_english.txt");
            //double average = Words.Average(word => word.Length);
            //Console.WriteLine($"The average length of the words in dictionary_english.txt is ==> {average}");

            #endregion

            #region 9. Get the total units in stock for each product category.

            //var unitsInStock = ProductList.GroupBy(p => p.Category)
            //                              .Select(category => new { Name = category.Key , totalUnitsInStock = category.Sum(p => p.UnitsInStock) });
            //foreach(var item in unitsInStock)
            //{
            //    Console.WriteLine($"Category Name: {item.Name}, Total Units in stock: {item.totalUnitsInStock}");
            //}

            // OR:

            //var unitsInStockQuery = from category in (
            //                            from p in ProductList
            //                            group p by p.Category
            //                        )
            //                        select new { Name = category.Key, totalUnitsInStock = category.Sum(p => p.UnitsInStock) };
            //foreach (var item in unitsInStockQuery)
            //{
            //    Console.WriteLine($"Category Name: {item.Name}, Total Units in stock: {item.totalUnitsInStock}");
            //}

            #endregion

            #region 10. Get the cheapest price among each category's products

            //var theCheapestInEachCategory = ProductList.GroupBy(p => p.Category)
            //                                           .Select(category => new { CategoryName = category.Key,
            //                                                                     CheapestProductPrice = category.Min(p => p.UnitPrice) });
            //foreach (var item in theCheapestInEachCategory)
            //{
            //    Console.WriteLine($"Category Name: {item.CategoryName}, Cheapest Product Price in the Category: {item.CheapestProductPrice}");
            //}

            //// OR:
            //Console.WriteLine(new string('-', 100));

            //var theCheapestInEachCategoryQuery = from category in
            //                                     (
            //                                        from p in ProductList
            //                                        group p by p.Category
            //                                     )
            //                                     select new
            //                                     {
            //                                         CategoryName = category.Key,
            //                                         CheapestProductPrice = category.Min(p => p.UnitPrice)
            //                                     };
            //foreach (var item in theCheapestInEachCategoryQuery)
            //{
            //    Console.WriteLine($"Category Name: {item.CategoryName}, Cheapest Product Price in the Category: {item.CheapestProductPrice}");
            //}

            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)

            //var cheapestProductPerCategory = ProductList.GroupBy(x => x.Category)
            //                                            .Select(category => new { CategoryName = category.Key, CheapestProduct = category.MinBy(p => p.UnitPrice) });
            //foreach (var category in cheapestProductPerCategory)
            //{
            //    Console.WriteLine($"Category: {category.CategoryName} has the cheapest product => \n{category.CheapestProduct}\n");
            //}


            //// OR: using let ========================> 
            //Console.WriteLine(new string('-', 100));


            //var cheapestProductPerCategoryQuery = from category in ProductList.GroupBy(p => p.Category)
            //                                      let cheapestProduct = category.MinBy(p => p.UnitPrice)
            //                                      select new
            //                                      {
            //                                          CategoryName = category.Key,
            //                                          CheapestProduct = cheapestProduct
            //                                      };

            //foreach (var category in cheapestProductPerCategoryQuery)
            //{
            //    Console.WriteLine($"Category: {category.CategoryName} has the cheapest product => \n{category.CheapestProduct}\n");
            //}


            // // OR:


            //var cheapestProductPerCategoryQuery_1 = from category in (from p in ProductList
            //                                                        group p by p.Category)
            //                                      select new { CategoryName = category.Key, CheapestProduct = category.MinBy(p => p.UnitPrice) };
            //foreach (var category in cheapestProductPerCategoryQuery_1)
            //{
            //    Console.WriteLine($"Category: {category.CategoryName} has the cheapest product => \n{category.CheapestProduct}\n");
            //}

            #endregion

            #region 12. Get the most expensive price among each category's products.

            //var theCheapestInEachCategory = ProductList.GroupBy(p => p.Category)
            //                                           .Select(category => new
            //                                           {
            //                                               CategoryName = category.Key,
            //                                               MostExpensiveProductPrice = category.Max(p => p.UnitPrice)
            //                                           });
            //foreach (var item in theCheapestInEachCategory)
            //{
            //    Console.WriteLine($"Category Name: {item.CategoryName}, Most Expensive Product Price in the Category: {item.MostExpensiveProductPrice}");
            //}

            //// OR:
            //Console.WriteLine(new string('-', 100));

            //var theCheapestInEachCategoryQuery = from category in
            //                                     (
            //                                        from p in ProductList
            //                                        group p by p.Category
            //                                     )
            //                                     select new
            //                                     {
            //                                         CategoryName = category.Key,
            //                                         MostExpensiveProductPrice = category.Max(p => p.UnitPrice)
            //                                     };
            //foreach (var item in theCheapestInEachCategoryQuery)
            //{
            //    Console.WriteLine($"Category Name: {item.CategoryName}, Most Expensive Product Price in the Category: {item.MostExpensiveProductPrice}");
            //}

            #endregion

            #region 13. Get the products with the most expensive price in each category.

            //var mostExpensiveProductPerCategory = ProductList.GroupBy(x => x.Category)
            //                                            .Select(category => new { CategoryName = category.Key, MostExpensiveProduct = category.MaxBy(p => p.UnitPrice) });
            //foreach (var category in mostExpensiveProductPerCategory)
            //{
            //    Console.WriteLine($"Category: {category.CategoryName} has the most expensive product => \n{category.MostExpensiveProduct}\n");
            //}


            //// OR:
            //Console.WriteLine(new string('-', 100));


            //var mostExpensiveProductPerCategoryQuery = from category in (from p in ProductList
            //                                                        group p by p.Category)
            //                                      select new { CategoryName = category.Key, MostExpensiveProduct = category.MaxBy(p => p.UnitPrice) };
            //foreach (var category in mostExpensiveProductPerCategoryQuery)
            //{
            //    Console.WriteLine($"Category: {category.CategoryName} has the most expensive product => \n{category.MostExpensiveProduct}\n");
            //}

            #endregion

            #region 14. Get the average price of each category's products.

            //var averageProductPricePerCategory = ProductList.GroupBy(x => x.Category)
            //                                                .Select(category => new { CategoryName = category.Key, 
            //                                                                          AveragePrice = Math.Round(category.Average(p => p.UnitPrice), 2)
            //                                                                        });
            //foreach (var category in averageProductPricePerCategory)
            //{
            //    Console.WriteLine($"Category: {category.CategoryName} has the cheapest product => \n{category.AveragePrice}\n");
            //}


            //// OR:
            //Console.WriteLine(new string('-', 100));


            //var averageProductPricePerCategoryQuery = from category in (from p in ProductList
            //                                                        group p by p.Category)
            //                                          select new
            //                                          {
            //                                              CategoryName = category.Key,
            //                                              AveragePrice = Math.Round(category.Average(p => p.UnitPrice), 2)
            //                                          };
            //foreach (var category in averageProductPricePerCategoryQuery)
            //{
            //    Console.WriteLine($"Category: {category.CategoryName} has the cheapest product => \n{category.AveragePrice}\n");
            //}

            #endregion

            #endregion

            #region Set Operators

            #region 1. Find the unique Category names from Product List

            //var uniqueCategories = Enumerable.Distinct(ProductList.Select(p => p.Category));
            //Console.WriteLine(string.Join(", ", uniqueCategories));

            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var productUniqeChars = Enumerable.Distinct(ProductList.Select(p => p.ProductName.FirstOrDefault()));

            //var customerUniqeChars = Enumerable.Distinct(CustomerList.Select(c => c.CustomerName.FirstOrDefault()));

            //var resultSeq = productUniqeChars.Union(customerUniqeChars);

            //Console.WriteLine(string.Join(", ", resultSeq));


            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names

            //var productUniqeChars = Enumerable.Distinct(ProductList.Select(p => p.ProductName.FirstOrDefault()));

            //var customerUniqeChars = Enumerable.Distinct(CustomerList.Select(c => c.CustomerName.FirstOrDefault()));

            //var commonFirstLetters = productUniqeChars.Intersect(customerUniqeChars);

            //Console.WriteLine(string.Join(", ", commonFirstLetters));

            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var productUniqeChars = Enumerable.Distinct(ProductList.Select(p => p.ProductName.FirstOrDefault()));

            //var customerUniqeChars = Enumerable.Distinct(CustomerList.Select(c => c.CustomerName.FirstOrDefault()));

            //var productCharsNotCommon = productUniqeChars.Except(customerUniqeChars);

            //Console.WriteLine(string.Join(", ", productCharsNotCommon));
            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var last3CharsProduct = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3));

            //var last3CharsCustomer = CustomerList.Select(c => c.CustomerName.Substring(c.CustomerName.Length - 3));

            //var last3CharsOfBoth = last3CharsProduct.Concat(last3CharsCustomer);
            //Console.WriteLine(string.Join(", ", last3CharsOfBoth));
            //Console.WriteLine("\n");

            #endregion

            #endregion

            #region Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] Words = ReadFile("dictionary_english.txt");

            //bool isAnyOfTheWordsHasEI = Words.Any(word => word.IndexOf("ei") != -1);

            //Console.WriteLine(isAnyOfTheWordsHasEI ? "is Any Of The Words Has 'ei' => yes" : "is Any Of The Words Has 'ei' => no");

            //// // another test case:

            //string[] names = { "ahmed", "khaled", "Mosa" };

            //bool isAnyOfTheNamesHasEI = names.Any(word => word.IndexOf("ei") != -1);

            //Console.WriteLine(isAnyOfTheNamesHasEI ? "is Any Of The Words Has 'ei' => yes" : "is Any Of The Words Has 'ei' => no");


            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock

            //var groupedListOfProducts = ProductList.GroupBy(p => p.Category).Where(c => c.Any(p => p.UnitsInStock == 0));

            //foreach (var category in groupedListOfProducts)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}


            //// OR:
            //Console.WriteLine(new string('-', 120));


            //var groupedListOfProductsQuery = from category in (from p in ProductList group p by p.Category)
            //                                 where category.Any(p => p.UnitsInStock == 0)
            //                                 select category;
            //foreach (var category in groupedListOfProductsQuery)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}

            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var groupedListOfProducts = ProductList.GroupBy(p => p.Category).Where(c => c.All(p => p.UnitsInStock > 0));

            //foreach (var category in groupedListOfProducts)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}

            // // OR:
            //Console.WriteLine(new string('-', 120));


            //var groupedListOfProductsQuery = from category in (from p in ProductList group p by p.Category) 
            //                                 where category.All(p => p.UnitsInStock > 0)
            //                                 select category;
            //foreach (var category in groupedListOfProductsQuery)
            //{
            //    Console.WriteLine($"Category: {category.Key}");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}

            #endregion

            #endregion

        }

        public static string[] ReadFile(string path)
        {
            try
            {
                List<string> Words = [];
                StreamReader sr = new StreamReader(path);       //Pass the file path and file name to the StreamReader constructor
                string? line = sr.ReadLine();                   //Read the first line of text
                while (line != null)                            //Continue to read until you reach end of file
                {
                    line = sr.ReadLine();                       //Read the next line
                    if(line != null)
                        Words.Add(line);
                }
                sr.Close();
                return Words.ToArray();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
                return Enumerable.Empty<string>().ToArray();
            }
        }
    }
}
