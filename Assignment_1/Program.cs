using Assignment_1.Part2;
using System.Runtime.Intrinsics.X86;
using C__Session_12.Built_inDelegate;
using C__Session_12.Delegate_Example_2;
using C__Session_12.Delegate_Example_2_With_Generics;
using C__Session_12.More_Generics;
using Assignment_1.MyListMethods;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part01: 1. Try Every Point Covered in the Lecture

            #region Example_1 BubbleSort(Desc and Asc) using delegate without repeating the same code for just small symbol: '<' and '>'

            //int[] numbers = { 5, 3, 5, 2, 1, 6, 3, 2 };

            //Console.WriteLine(string.Join(' ', numbers));

            //SortingAlgorithms.BubbleSortAsc(numbers);

            //Console.WriteLine(string.Join(' ', numbers));

            //SortingAlgorithms.BubbleSortDesc(numbers);

            //Console.WriteLine(string.Join(' ', numbers));

            //SortingAlgorithms.BubbleSortUsingDelegateWithoutRepeating(numbers, SortingCompareBasedOnDelegate.SortAsc); // delegate_1) either pass the method directly to the delegate

            //Console.WriteLine(string.Join(' ', numbers));

            ////CompareSortingDelegate compare = new CompareSortingDelegate(SortingCompareBasedOnDelegate.SortDesc); // delegate_2) or declare and initialize a delegate using new
            //CompareSortingDelegate compare = SortingCompareBasedOnDelegate.SortDesc; // delegate_3) or declare and initialize a delegate directly without new
            //SortingAlgorithms.BubbleSortUsingDelegateWithoutRepeating(numbers, compare);

            //Console.WriteLine(string.Join(' ', numbers));

            //CompareSortingDelegate nullDelegate = default;
            //SortingAlgorithms.BubbleSortUsingDelegateWithoutRepeating(numbers, nullDelegate);

            //Console.WriteLine(string.Join(' ', numbers));

            #endregion


            #region Delegate Example 2 With Generics 

            //int[] numbers = { 3, 4, 7, 1, 9, 10, 3, 2, 5, 1, 5, 2, 0 };

            //Console.WriteLine(string.Join(" , ", numbers));

            //SortingAlgorithmsGeneric<int>.BubbleSort(numbers, SortingCompareBasedOnGenericDelegate.SortNumbersAsc);

            //Console.WriteLine(string.Join(" , ", numbers));


            //CompareTypesGenericDelegate<int, int, bool> compareTypes01 = SortingCompareBasedOnGenericDelegate.SortNumbersDesc;
            //SortingAlgorithmsGeneric<int>.BubbleSort(numbers, compareTypes01);

            //Console.WriteLine(string.Join(" , ", numbers));


            ////--------Now try array of strings

            //string[] names = { "Ahmed", "Mohamed", "Yasser", "Ali", "Mosa", "Hossam", "Sama", "Dalia", "Mariam", "Omar" };

            //Console.WriteLine(string.Join(" , ", names));

            //SortingAlgorithmsGeneric<string>.BubbleSort(names, SortingCompareBasedOnGenericDelegate.SortStringsAsc);

            //Console.WriteLine(string.Join(" , ", names));


            //CompareTypesGenericDelegate<string, string, bool> compareTypes02 = SortingCompareBasedOnGenericDelegate.SortStringsDesc;
            //SortingAlgorithmsGeneric<string>.BubbleSort(names, compareTypes02);

            //Console.WriteLine(string.Join(" , ", names));

            #endregion


            #region Example 3 More Generics on Delegate:

            //List<int> elements = Enumerable.Range(0, 20).ToList();

            //Console.WriteLine(string.Join(" , ", elements));

            //List<int> returnElements = GetElementsBasedOnCondition<int>.GetElements(elements, ConditionBasedDelegate.IsEven);

            //Console.WriteLine(string.Join(" , ", returnElements));

            //returnElements = GetElementsBasedOnCondition<int>.GetElements(elements, ConditionBasedDelegate.IsOdd);

            //Console.WriteLine(string.Join(" , ", returnElements));

            //returnElements = GetElementsBasedOnCondition<int>.GetElements(elements, ConditionBasedDelegate.IsDevideBy7);

            //Console.WriteLine(string.Join(" , ", returnElements));


            //List<string> students = ["Ahmed", "Mohamed", "Yasser", "Ali", "Mosa", "Hossam", "Sama", "Dalia", "Mariam", "Omar", "aliaa", "adham"];

            //List<string> studentsWithNameLengthMoreThan3 = GetElementsBasedOnCondition<string>.GetElements(students, ConditionBasedDelegate.IsLengthMoreThan3);

            //Console.WriteLine(string.Join(" , ", studentsWithNameLengthMoreThan3));


            //ConditionDelegate<string> startsWith = ConditionBasedDelegate.IsStartWithA;

            //List<string> studentNamesStartsWithA = GetElementsBasedOnCondition<string>.GetElements(students, startsWith);

            //Console.WriteLine(string.Join(" , ", studentNamesStartsWithA));

            #endregion


            #region Built-in Delegates [ Func - Action - Predicate ]

            //// --------------------- Func ------------------------

            //Func<int, string> func = TestBuiltDelegates.Casting;

            //Console.WriteLine($"What Type ? => {func.Invoke(1234).GetType()}");
            //Console.WriteLine($"What Type ? => {func(1234).GetType()}");

            ////---------------------Predicate------------------------
            //Predicate<int> predicate = TestBuiltDelegates.CheckPositive;
            //Console.WriteLine($"CheckPositive => {predicate.Invoke(-10)}");
            //Console.WriteLine($"CheckPositive => {predicate(10)}");


            //Func<int, bool> predicate01 = TestBuiltDelegates.CheckPositive;
            //Console.WriteLine($"CheckPositive => {predicate01.Invoke(-10)}");
            //Console.WriteLine($"CheckPositive => {predicate01(10)}");


            //// --------------------- Action ------------------------

            //Action action = TestBuiltDelegates.Print;

            //action.Invoke();
            //action();

            //Action<string> action1 = TestBuiltDelegates.Print;

            //action1.Invoke("Ahmed");
            //action1("Ahmed");


            //// --------------------- Using Built-in Delegates instead of ours in above Examples ------------------------
            //int[] numbers = { 5, 3, 5, 2, 1, 6, 3, 2 };
            //Console.WriteLine(string.Join(' ', numbers));


            ////CompareSortingDelegate compare = SortingCompareBasedOnDelegate.SortAsc; // XX
            //Func<int, int, bool> compare = SortingCompareBasedOnDelegate.SortAsc;
            //SortingAlgorithms.BubbleSortUsingBuiltInDelegate(numbers, compare);
            //Console.WriteLine(string.Join(' ', numbers));


            ////CompareSortingDelegate compare = SortingCompareBasedOnDelegate.SortDesc; // XX
            //compare = SortingCompareBasedOnDelegate.SortDesc;
            //SortingAlgorithms.BubbleSortUsingBuiltInDelegate(numbers, compare);
            //Console.WriteLine(string.Join(' ', numbers));


            ////CompareSortingDelegate nullDelegate = default; // XX
            //compare = default;
            //SortingAlgorithms.BubbleSortUsingBuiltInDelegate(numbers, compare);
            //Console.WriteLine(string.Join(' ', numbers));



            // --------------------------------------------------------------------------------



            //int[] numbers = { 3, 4, 7, 1, 9, 10, 3, 2, 5, 1, 5, 2, 0 };

            ////CompareTypesGenericDelegate<int, int, bool> compareTypes01 = SortingCompareBasedOnGenericDelegate.SortNumbersDesc; // XX
            ////SortingAlgorithmsGeneric<int>.BubbleSortUsingBuiltInDelegate(numbers, compareTypes01); // XX

            //Func<int, int, bool> compare = SortingCompareBasedOnGenericDelegate.SortNumbersDesc;
            //SortingAlgorithmsGeneric<int>.BubbleSortUsingBuiltInDelegate(numbers, compare);
            //Console.WriteLine(string.Join(" , ", numbers));


            //string[] names = { "Ahmed", "Mohamed", "Yasser", "Ali", "Mosa", "Hossam", "Sama", "Dalia", "Mariam", "Omar" };

            ////CompareTypesGenericDelegate<string, string, bool> compareTypes02 = SortingCompareBasedOnGenericDelegate.SortStringsDesc; // XX
            ////SortingAlgorithmsGeneric<string>.BubbleSort(names, compareTypes02); // XX

            //Func<string, string, bool> compareTypes02 = SortingCompareBasedOnGenericDelegate.SortStringsDesc;
            //SortingAlgorithmsGeneric<string>.BubbleSortUsingBuiltInDelegate(names, compareTypes02);
            //Console.WriteLine(string.Join(" , ", names));



            // --------------------------------------------------------------------------------


            //List<int> elements = Enumerable.Range(0, 20).ToList();
            //Console.WriteLine(string.Join(" , ", elements));


            //Predicate<int> predicate01 = ConditionBasedDelegate.IsEven;
            //List<int> returnElements = GetElementsBasedOnCondition<int>.GetElementsUsingBuiltInDelegate(elements, predicate01);
            //Console.WriteLine(string.Join(" , ", returnElements));


            //Predicate<int> predicate02 = ConditionBasedDelegate.IsOdd;
            //returnElements = GetElementsBasedOnCondition<int>.GetElementsUsingBuiltInDelegate(elements, predicate02);
            //Console.WriteLine(string.Join(" , ", returnElements));


            //Predicate<int> predicate03 = ConditionBasedDelegate.IsDevideBy7;
            //returnElements = GetElementsBasedOnCondition<int>.GetElementsUsingBuiltInDelegate(elements, predicate03);
            //Console.WriteLine(string.Join(" , ", returnElements));


            //List<string> students = ["Ahmed", "Mohamed", "Yasser", "Ali", "Mosa", "Hossam", "Sama", "Dalia", "Mariam", "Omar", "aliaa", "adham"];
            //Console.WriteLine(string.Join(" , ", students));


            //Predicate<string> predicate04 = ConditionBasedDelegate.IsLengthMoreThan3;
            //List<string> studentsWithNameLengthMoreThan3 = GetElementsBasedOnCondition<string>.GetElementsUsingBuiltInDelegate(students, predicate04);
            //Console.WriteLine(string.Join(" , ", studentsWithNameLengthMoreThan3));


            ////ConditionDelegate<string> startsWith = ConditionBasedDelegate.IsStartWithA; // XX
            ////List<string> studentNamesStartsWithA = GetElementsBasedOnCondition<string>.GetElements(students, startsWith); // XX

            //Predicate<string> predicate05 = ConditionBasedDelegate.IsStartWithA;
            //List<string> studentNamesStartsWithA = GetElementsBasedOnCondition<string>.GetElementsUsingBuiltInDelegate(students, predicate05);
            //Console.WriteLine(string.Join(" , ", studentNamesStartsWithA));


            #endregion


            #region Anonymous Method C#2 [2005]

            //Func<int, string> func = delegate (int num) { return num.ToString(); };
            //Console.WriteLine($"What Type ? => {func.Invoke(1234).GetType()}");
            //Console.WriteLine($"What Type ? => {func(1234).GetType()}");


            //Predicate<int> predicate = delegate (int num) { return num > 0; };
            //Console.WriteLine($"CheckPositive => {predicate.Invoke(-10)}");
            //Console.WriteLine($"CheckPositive => {predicate(10)}");


            //Func<int, bool> predicate01 = delegate (int num) { return num > 0; };
            //Console.WriteLine($"CheckPositive => {predicate01.Invoke(-10)}");
            //Console.WriteLine($"CheckPositive => {predicate01(10)}");


            //Action action = delegate { Console.WriteLine("Hello,, "); };
            //action.Invoke();
            //action();


            //Action<string> action1 = delegate (string name) { Console.WriteLine($"Hello, {name}"); };
            //action1.Invoke("Ahmed");
            //action1("Ahmed");

            #endregion


            #region Lambda Expression C#3 [2007] .NET Framework 3.5

            //Action action01 = () => Console.WriteLine("Hello Ahmed");
            //action01.Invoke();
            //action01();


            //Action<string> action02 = name => Console.WriteLine($"Hello, {name}");
            //action02.Invoke("Ahmed");
            //action02("Omar");


            //Func<int, string> func01 = number => number.ToString();
            //Console.WriteLine($"Type ? {func01.Invoke(100).GetType}");
            //Console.WriteLine($"Type ? {func01(300).GetType}");


            //Predicate<int> predicate01 = N => N > 0;
            //Console.WriteLine($"is positive ? : {predicate01(10)}");
            //Console.WriteLine($"is positive ? : {predicate01.Invoke(-4)}");

            #endregion

            #endregion


            #region Part 02:

            #region Part 02: 1. Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor:

            // Done

            #endregion

            #region Part 02: 2. You need to parameterize ProcessBooks function to accept BookFunctions Methods using following cases: Create User Defined Delegate with the same signature of methods existed in Bookfunctions class. Use the Proper build in delegate.  Anonymous Method (GetISBN). Lambda Expression (GetPublicationDate).

            //List<Book> list = [
            //    new Book("abs123", "Clean Code", ["Ahmed", "Mohmaed", "Salah"], new DateTime(2005, 12, 30), 20),
            //    new Book("xyz456", "The Pragmatic Programmer", new string[] { "Andrew Hunt", "David Thomas" }, new DateTime(1999, 10, 20), 35),
            //    new Book("pqr789", "Refactoring", new string[] { "Martin Fowler" }, new DateTime(2002, 03, 09), 30),
            //    new Book("lmn012", "Design Patterns", new string[] { "Erich Gamma", "Richard Helm", "Ralph Johnson", "John Vlissides" }, new DateTime(1994, 11, 10), 40),
            //    new Book("stu345", "Effective Java", new string[] { "Joshua Bloch" }, new DateTime(2001, 05, 01), 25),
            //    new Book("vwy678", "Head First Java", new string[] { "Bert Bates", "Kathy Sierra" }, new DateTime(2005, 01, 15), 28),
            //    new Book("def901", "Thinking in Java", new string[] { "Bruce Eckel" }, new DateTime(2006, 06, 22), 32),
            //    new Book("ghi234", "Cracking the Coding Interview", new string[] { "Gayle Laakmann McDowell" }, new DateTime(2015, 07, 03), 22),
            //    new Book("jkl567", "Introduction to Algorithms", new string[] { "Thomas H. Cormen", "Charles E. Leiserson", "Ronald L. Rivest", "Clifford Stein" }, new DateTime(2009, 09, 18), 50),
            //    new Book("mno890", "Code Complete", new string[] { "Steve McConnell" }, new DateTime(2004, 08, 25), 38)
            //];


            //BookDelegate bookDelegate01 = BookFunctions.GetTitle;
            //LibraryEngine.ProcessBooks(list, bookDelegate01);


            //Console.WriteLine("\n--------------------------- ------------------------ -------------------------\n\n");


            //Func<Book, string> bookDelegate02 = BookFunctions.GetAuthors;
            //LibraryEngine.ProcessBooks(list, bookDelegate02);


            //Console.WriteLine("\n--------------------------- ------------------------ -------------------------\n\n");


            //Func<Book, string> bookDelegate03 = delegate (Book b) { return b.ISBN; }; // c) Anonymous Method (GetISBN).
            //LibraryEngine.ProcessBooks(list, bookDelegate03);


            //Console.WriteLine("\n--------------------------- ------------------------ -------------------------\n\n");


            //BookDelegate bookDelegate04 = (Book b) => b.PublicationDate.ToString(); // d) Lambda Expression (GetPublicationDate).
            //LibraryEngine.ProcessBooks(list, bookDelegate04);


            //Console.WriteLine("\n--------------------------- ------------------------ -------------------------\n\n");


            //Func<Book, string> bookDelegate05 = (Book b) => b.PublicationDate.ToString(); // d) Lambda Expression (GetPublicationDate).
            //LibraryEngine.ProcessBooks(list, bookDelegate05);

            #endregion

            #endregion


            #region Part 03: We need to Implement the List methods from scratch with all overloads.

            #region Exists

            //List<int> elements = [2, 3, 6, 5, 2, 10];
            //Console.WriteLine($"Is there a number in the list of numbers divided by 2 ? {elements.Exists(element => element % 2 == 0)}");
            //Console.WriteLine($"Is there a number in the list of numbers divided by 7 ? {elements.Exists(element => element % 7 == 0)}");

            //CustomList<int> customElements = new CustomList<int>([2, 3, 6, 5, 2, 10]);
            //Console.WriteLine($"Is there a number in the list of numbers divided by 2 ? {customElements.Exists(element => element % 2 == 0)}");
            //Console.WriteLine($"Is there a number in the list of numbers divided by 7 ? {customElements.Exists(element => element % 7 == 0)}");


            //List<string> names = ["ahmed", "amr", "ali", "osama", "Mena", "saber"];
            //Console.WriteLine($"Is there a name that has Length > 5 ? {names.Exists(name => name?.Length > 5)}");
            //Console.WriteLine($"Is there a name that has Length > 3 ? {names.Exists(name => name?.Length > 3)}");

            //CustomList<string> customNames = new CustomList<string>(["ahmed", "amr", "ali", "osama", "Mena", "saber"]);
            //Console.WriteLine($"Is there a name that has Length > 5 ? {customNames.Exists(name => name?.Length > 5)}");
            //Console.WriteLine($"Is there a name that has Length > 3 ? {customNames.Exists(name => name?.Length > 3)}");

            #endregion

            #region Find

            //List<int> elements = [2, 3, 6, 15 , 5, 2, 10];
            //Console.WriteLine($"What is the First number divided by 5 ? {elements.Find(element => element % 5 == 0)}");
            //Console.WriteLine($"What is the First number divided by 7 ? {elements.Find(element => element % 7 == 0)}");

            //CustomList<int> customElements = new CustomList<int>([2, 3, 6, 15, 5, 2, 10]);
            //Console.WriteLine($"What is the First number divided by 5 ? {customElements.Find(element => element % 5 == 0)}");
            //Console.WriteLine($"What is the First number divided by 7 ? {customElements.Find(element => element % 7 == 0)}");


            //List<string> names = ["ahmed", "amr", "ali", "osama", "saber"];
            //Console.WriteLine($"What is the first name that has Length > 5 ? {names.Find(name => name?.Length > 5)}");
            //Console.WriteLine($"What is the first name that has Length > 3 ? {names.Find(name => name?.Length > 3)}");

            //CustomList<string> customNames = new CustomList<string>(["ahmed", "amr", "ali", "osama", "saber"]);
            //Console.WriteLine($"What is the first name that has Length > 5 ? {names.Find(name => name?.Length > 5)}");
            //Console.WriteLine($"What is the first name that has Length > 3 ? {names.Find(name => name?.Length > 3)}");

            #endregion

            #region Find All

            //List<int> elements = [2, 3, 6, 15, 5, 2, 10];
            //Console.WriteLine($"What are the numbera divided by 5 ? {string.Join(" ", elements.FindAll(element => element % 5 == 0))}");
            //Console.WriteLine($"What are the numbera divided by 7 ? {string.Join(" ", elements.FindAll(element => element % 7 == 0))}");

            //CustomList<int> customElements = new CustomList<int>([2, 3, 6, 15, 5, 2, 10]);
            //Console.WriteLine($"What are the numbera divided by 5 ? {string.Join(" ", customElements.FindAll(element => element % 5 == 0))}");
            //Console.WriteLine($"What are the numbera divided by 7 ? {string.Join(" ", customElements.FindAll(element => element % 7 == 0))}");


            //List<string> names = ["ahmed", "amr", "ali", "osama", "saber"];
            //Console.WriteLine($"What are the names that has Length > 5 ? {string.Join(" ", names.FindAll(name => name?.Length > 5))}");
            //Console.WriteLine($"What are the names that has Length > 3 ? {string.Join(" ", names.FindAll(name => name?.Length > 3))}");

            //CustomList<string> customNames = new CustomList<string>(["ahmed", "amr", "ali", "osama", "saber"]);
            //Console.WriteLine($"What are the names that has Length > 5 ? {string.Join(" ", customNames.FindAll(name => name?.Length > 5))}");
            //Console.WriteLine($"What are the names that has Length > 3 ? {string.Join(" ", customNames.FindAll(name => name?.Length > 3))}");

            #endregion

            #region FindIndex

            //List<int> elements = [2, 3, 6, 15 , 5, 2, 10];
            //Console.WriteLine($"What is the First index of a number divided by 5 ? {elements.FindIndex(element => element % 5 == 0)}");
            //Console.WriteLine($"What is the First index of a number divided by 7 ? {elements.FindIndex(element => element % 7 == 0)}");

            //CustomList<int> customElements = new CustomList<int>([2, 3, 6, 15, 5, 2, 10]);
            //Console.WriteLine($"What is the First index of a number divided by 5 ? {customElements.FindIndex(element => element % 5 == 0)}");
            //Console.WriteLine($"What is the First index of a number divided by 7 ? {customElements.FindIndex(element => element % 7 == 0)}");


            //List<string> names = ["ahmed", "amr", "ali", "osama", "saber"];
            //Console.WriteLine($"What is the First index of a name that has Length > 5 ? {names.FindIndex(name => name?.Length > 5)}");
            //Console.WriteLine($"What is the First index of a name that has Length > 3 ? {names.FindIndex(name => name?.Length > 3)}");

            //CustomList<string> customNames = new CustomList<string>(["ahmed", "amr", "ali", "osama", "saber"]);
            //Console.WriteLine($"What is the First index of a name that has Length > 5 ? {customNames.FindIndex(name => name?.Length > 5)}");
            //Console.WriteLine($"What is the First index of a name that has Length > 3 ? {customNames.FindIndex(name => name?.Length > 3)}");

            #endregion

            #region FindLast

            //List<int> elements = [2, 3, 6, 15, 5, 2, 10];
            //Console.WriteLine($"What is the Last number divided by 5 ? {elements.FindLast(element => element % 5 == 0)}");
            //Console.WriteLine($"What is the Last number divided by 7 ? {elements.FindLast(element => element % 7 == 0)}");

            //CustomList<int> customElements = new CustomList<int>([2, 3, 6, 15, 5, 2, 10]);
            //Console.WriteLine($"What is the Last number divided by 5 ? {customElements.FindLast(element => element % 5 == 0)}");
            //Console.WriteLine($"What is the Last number divided by 7 ? {customElements.FindLast(element => element % 7 == 0)}");


            //List<string> names = ["ahmed", "amr", "ali", "osama", "saber"];
            //Console.WriteLine($"What is the Last name that has Length > 5 ? {names.FindLast(name => name?.Length > 5)}");
            //Console.WriteLine($"What is the Last name that has Length > 3 ? {names.FindLast(name => name?.Length > 3)}");

            //CustomList<string> customNames = new CustomList<string>(["ahmed", "amr", "ali", "osama", "saber"]);
            //Console.WriteLine($"What is the Last name that has Length > 5 ? {customNames.FindLast(name => name?.Length > 5)}");
            //Console.WriteLine($"What is the Last name that has Length > 3 ? {customNames.FindLast(name => name?.Length > 3)}");

            #endregion

            #region FindLastIndex

            //List<int> elements = [2, 3, 6, 15, 5, 2, 10];
            //Console.WriteLine($"What is the Last number divided by 5 ? {elements.FindLastIndex(element => element % 5 == 0)}");
            //Console.WriteLine($"What is the Last number divided by 7 ? {elements.FindLastIndex(element => element % 7 == 0)}");

            //CustomList<int> customElements = new CustomList<int>([2, 3, 6, 15, 5, 2, 10]);
            //Console.WriteLine($"What is the Last number divided by 5 ? {customElements.FindLastIndex(element => element % 5 == 0)}");
            //Console.WriteLine($"What is the Last number divided by 7 ? {customElements.FindLastIndex(element => element % 7 == 0)}");


            //List<string> names = ["ahmed", "amr", "ali", "osama", "saber"];
            //Console.WriteLine($"What is the Last name that has Length > 5 ? {names.FindLastIndex(name => name?.Length > 5)}");
            //Console.WriteLine($"What is the Last name that has Length > 3 ? {names.FindLastIndex(name => name?.Length > 3)}");

            //CustomList<string> customNames = new CustomList<string>(["ahmed", "amr", "ali", "osama", "saber"]);
            //Console.WriteLine($"What is the Last name that has Length > 5 ? {customNames.FindLastIndex(name => name?.Length > 5)}");
            //Console.WriteLine($"What is the Last name that has Length > 3 ? {customNames.FindLastIndex(name => name?.Length > 3)}");

            #endregion

            #region Foreach

            //Console.WriteLine("---------------------- List ForEach: ----------------------");
            //List<int> elements = [2, 3, 6, 15, 5, 2, 10];
            //elements.ForEach(element => Console.WriteLine($"element: {element}"));

            //Console.WriteLine("---------------------- My CustomList ForEach: ----------------------");
            //CustomList<int> customElements = new CustomList<int>([2, 3, 6, 15, 5, 2, 10]);
            //customElements.ForEach(element => Console.WriteLine($"element: {element}"));


            //Console.WriteLine("---------------------- List ForEach: ----------------------");
            //List<string> names = ["ahmed", "amr", "ali", "osama", "saber"];
            //names.ForEach(name => Console.WriteLine($"name: {name}"));

            //Console.WriteLine("---------------------- My CustomList ForEach: ----------------------");
            //CustomList<string> customNames = new CustomList<string>(["ahmed", "amr", "ali", "osama", "saber"]);
            //customNames.ForEach(name => Console.WriteLine($"name: {name}"));


            #endregion

            #region TrueForAll

            //Console.WriteLine("---------------------- List TrueForAll: ----------------------");
            //List<int> elements = [2, 3, 6, 15, 5, 2, 10];
            //Console.WriteLine($"Are all Numbers divided by 5 ? {elements.TrueForAll(element => element % 5 == 0)}");
            //Console.WriteLine($"Are all Numbers positives ? {elements.TrueForAll(element => element > 0)}");

            //Console.WriteLine("---------------------- My CustomList TrueForAll: ----------------------");
            //CustomList<int> customElements = new CustomList<int>([2, 3, 6, 15, 5, 2, 10]);
            //Console.WriteLine($"Are all Numbers divided by 5 ? {customElements.TrueForAll(element => element % 5 == 0)}");
            //Console.WriteLine($"Are all Numbers positives ? {customElements.TrueForAll(element => element > 0)}");


            //Console.WriteLine("---------------------- List TrueForAll: ----------------------");
            //List<string> names = ["ahmed", "amr", "ali", "osama", "saber"];
            //Console.WriteLine($"Are all Names have Length > 5 ? {names.TrueForAll(name => name.Length > 5)}");
            //Console.WriteLine($"Are all Names have Length > 2 ? {names.TrueForAll(name => name.Length > 2)}");

            //Console.WriteLine("---------------------- My CustomList TrueForAll: ----------------------");
            //CustomList<string> customNames = new CustomList<string>(["ahmed", "amr", "ali", "osama", "saber"]);
            //Console.WriteLine($"Are all Names have Length > 5 ? {customNames.TrueForAll(name => name.Length > 5)}");
            //Console.WriteLine($"Are all Names have Length > 2 ? {customNames.TrueForAll(name => name.Length > 2)}");

            #endregion

            #endregion


        }
    }
}
