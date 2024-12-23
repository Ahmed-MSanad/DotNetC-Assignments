namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment_2

            #region 1) Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no. Example(1) Input: 12 Output: Yes Example(2) Input: 9 Output: No

            //if (!int.TryParse(Console.ReadLine(), out int number) || number % 3 != 0 || number % 4 != 0)
            //{
            //    Console.WriteLine("No");
            //}
            //else
            //{
            //    Console.WriteLine("Yes");
            //}

            #endregion


            #region 2) Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive. Example(1) Input: -5 Output: negative Example(2) Input: 10 Output: positive

            //if(int.TryParse(Console.ReadLine(), out int number))
            //{
            //    if (number < 0) Console.WriteLine("Negative");
            //    else Console.WriteLine("Positive");
            //}

            #endregion


            #region 3) Write a program that takes 3 integers from the user then prints the max element and the min element. Example(1) Input: 7,8,5 Output: max element = 8 min element = 5 Example(2) Input: 3 6 9 Outputs: Max element = 9 Min element = 3

            //int[] numbers = new int[3];

            //for (int i = 0; i < numbers.Length; i++) {
            //    Console.Write($"Enter The {i+1} number: ");
            //    int.TryParse(Console.ReadLine(), out numbers[i]);
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = i+1; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] > numbers[j]) // then swap
            //        {
            //            numbers[i] = numbers[i] + numbers[j];
            //            numbers[j] = numbers[i] - numbers[j];
            //            numbers[i] -= numbers[j];
            //        }
            //    }
            //}

            //Console.WriteLine($"Max Element = {numbers[2]}\nMin Element = {numbers[0]}");


            #endregion


            #region 4) Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //if (int.TryParse(Console.ReadLine(), out int number)) {
            //    if (number % 2 == 0) Console.WriteLine($"{number} is an Even Number");
            //    else Console.WriteLine($"{number} is an Odd Number");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong Number !");
            //}

            #endregion


            #region 5) Write a program that takes character from the user then if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant). Example(1) Input: O Output: vowel Example(2) Input: b Output: Consonant

            //string vowels = "aAeEiIoOuU";
            //bool isVowel = false;

            //Console.Write("Enter a Character: ");

            //if(char.TryParse(Console.ReadLine(), out char character))
            //{
            //    for (int i = 0; i < vowels.Length; i++) isVowel |= character == vowels[i];

            //    if (isVowel) Console.WriteLine("vowel");
            //    else Console.WriteLine("Consonant");
            //}
            //else Console.WriteLine("Wrong Character !");


            #endregion


            #region 6) Write a program that allows the user to insert an integer then print all numbers between 1 to that number. Example Input: 5 Output: 1, 2, 3, 4, 5

            //Console.Write("Enter a number to print all numbers between 1 to that number: ");

            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    if (number < 1) Console.WriteLine("The number is less than 1!!");
            //    else
            //    {
            //        for (int i = 1; i <= number; i++) Console.Write($"{i}" + (i == number ? " " : ", "));
            //    }
            //}
            //else Console.WriteLine("It's not a Vaild Number !");

            #endregion


            #region 7) Write a program that allows the user to insert an integer then print a multiplication table up to 12. Example Input: 5 Outputs: 5 10 15 20 25 30 35 40 45 50 55 60

            //Console.Write("Enter a number to print a multiplication table up to 12: ");

            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    for (int i = 1; i <= 12; i++) Console.Write($"{number * i} ");
            //}
            //else Console.WriteLine("It's not a Vaild Number !");

            #endregion


            #region 8) Write a program that allows to user to insert number then print all even numbers between 1 to this number Example: Input: 15 Output: 2 4 6 8 10 12 14

            //Console.Write("Enter a number to print all even numbers between 1 to this number: ");

            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    for (int i = 1; i <= number; i++) if (i % 2 == 0) Console.Write($"{i} ");
            //}
            //else Console.WriteLine("It's not a Vaild Number !");

            #endregion


            #region 9) Write a program that takes two integers then prints the power. Example: Input: 4 3 Output: 64 Hint: how to calculate 4 ^ 3 = 4 * 4 * 4 = 64

            //Console.WriteLine("Enter 2 numbers to print the power");

            //Console.Write("Enter the number: ");
            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    Console.Write("Enter the power: ");
            //    if (int.TryParse(Console.ReadLine(), out int power))
            //    {
            //        int answer = number;
            //        for (int i = 1; i < power; i++) answer *= number;

            //        Console.Write(answer);
            //    }
            //    else Console.WriteLine("It's not a Vaild Number !");
            //}
            //else Console.WriteLine("It's not a Vaild Number !");

            #endregion


            #region 10) Write a program to enter marks of five subjects and calculate total, average and percentage. Example Input: -Enter Marks of five subjects: 95 76 58 90 89 Output: Total marks = 408 Average Marks = 81 Percentage = 81

            //Console.Write("Enter Marks of five subjects: ");

            //double[] numbers = new double[5];

            //bool areAllVaildMarks = true;

            //for (int i = 0; i < 5; i++)
            //{
            //    areAllVaildMarks = double.TryParse(Console.ReadLine(), out numbers[i]);
            //    if (!areAllVaildMarks) { Console.WriteLine("Wrong Mark !"); break; }
            //}

            //if (areAllVaildMarks)
            //{
            //    double total = 0;
            //    for (int i = 0; i < 5; i++) total += numbers[i];

            //    Console.WriteLine($"Total marks = {total}");
            //    Console.WriteLine($"Average Marks = {total / 5.0}");
            //    Console.WriteLine($"Percentage = {(total / 500.0) * 100}");
            //}

            #endregion


            #region 11) Write a program to input the month number and print the number of days in that month. Example Input: Month Number: 1 Output: Days in Month: 31

            //int monthNumber;
            //Console.Write("Enter Month Number (1-12): ");

            //int.TryParse(Console.ReadLine(), out monthNumber);

            //string daysInMonth = monthNumber switch
            //{
            //    1 or 3 or 5 or 7 or 8 or 10 or 12 => "Days in Month: 31",
            //    4 or 6 or 9 or 11 => "Days in Month: 30",
            //    2 => "Days in Month: 28 or 29",
            //    _ => "Unknown Month !!"
            //};

            //Console.WriteLine(daysInMonth);

            #endregion


            #region 12) Write a program to create a Simple Calculator.

            //double num1, num2;
            //char operation;

            //Console.Write("Enter first number: ");
            //while (!double.TryParse(Console.ReadLine(), out num1))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //    Console.Write("Enter first number: ");
            //}

            //Console.Write("Enter one of these operators +, -, *, /: ");
            //while (!char.TryParse(Console.ReadLine(), out operation) || !"+-*/".Contains(operation))
            //{
            //    Console.WriteLine("Invalid operator. Please enter +, -, *, /.");
            //    Console.Write("Enter operator: ");
            //}

            //Console.Write("Enter second number: ");
            //while (!double.TryParse(Console.ReadLine(), out num2))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //    Console.Write("Enter second number: ");
            //}

            //double result = 0;

            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 == 0) {Console.WriteLine("Error: Division by zero is not allowed."); result = -1; }
            //        else result = num1 / num2;
            //        break;
            //}

            //Console.WriteLine($"Result: {num1} {operation} {num2} = " + (result == -1 ? "not Valid" : result));

            #endregion


            #region 13) Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter a string to print the REVERSE of it: ");
            //string InputString = Console.ReadLine() ?? "";

            //for (int i = InputString.Length - 1; i >= 0; i--) { 
            //    Console.Write(InputString[i]);
            //}

            #endregion


            #region 14) Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.Write("Enter a number to print the REVERSED of it: ");

            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    int reverse = 0;
            //    while (number != 0)
            //    {
            //        // 12345
            //        reverse = reverse * 10 + number % 10; // 5
            //        number = number / 10; // 1234
            //    }
            //    Console.Write($"The reverse is {reverse}");
            //}
            //else Console.WriteLine("It's not a Vaild Number !");

            #endregion


            #region 15) Write a program in C# Sharp to find prime numbers within a range of numbers. Test Data: Input starting number of range: 1 Input ending number of range: 50 Expected Output :The prime number between 1 and 50 are: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47

            //Console.WriteLine("Input starting number of range: ");

            //if (int.TryParse(Console.ReadLine(), out int start))
            //{
            //    Console.WriteLine("Input ending number of range : ");
            //    if (int.TryParse(Console.ReadLine(), out int end))
            //    {
            //        if (start > end) { Console.WriteLine("Not a Vaild Range !"); }
            //        else
            //        {
            //            for (int i = start; i <= end; i++)
            //            {
            //                bool isPrime = true;

            //                if (i < 2) isPrime = false;

            //                for (int j = 2; j * j <= i; j++) isPrime &= (i % j) != 0; // why j*j -> 36/6 = 6 then 36/9 = 4 it's same as 36/4 = 9

            //                if (isPrime) Console.Write($"{i} ");
            //            }
            //        }
            //    }
            //    else Console.WriteLine("It's not a Vaild End Number !");
            //}
            //else Console.WriteLine("It's not a Vaild Start Number !");


            #endregion


            #region 16) Write a program in C# Sharp to convert a decimal number into binary without using an array. Test Data: Enter a number to convert: 25 Expected Output : The Binary of 25 is 11001.

            //Console.Write("Enter a number to convert into binary: ");

            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    int bitsCount = (int)Math.Log2(number);
            //    Console.Write($"The Binary of {number} is ");
            //    while (bitsCount >= 0)
            //    {
            //        Console.Write(((1 << bitsCount) & number) > 0 ? 1 : 0);
            //        bitsCount--;
            //    }
            //}
            //else Console.WriteLine("It's not a Vaild Number !");

            #endregion


            #region 17) Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //double x1, y1, x2, y2, x3, y3;

            //Console.Write("Enter x1: ");
            //while (!double.TryParse(Console.ReadLine(), out x1))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //    Console.Write("Enter x1: ");
            //}
            //Console.Write("Enter y1: ");
            //while (!double.TryParse(Console.ReadLine(), out y1))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //    Console.Write("Enter y1: ");
            //}

            //Console.Write("Enter x2: ");
            //while (!double.TryParse(Console.ReadLine(), out x2))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //    Console.Write("Enter x2: ");
            //}
            //Console.Write("Enter y2: ");
            //while (!double.TryParse(Console.ReadLine(), out y2))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //    Console.Write("Enter y2: ");
            //}

            //Console.Write("Enter x3: ");
            //while (!double.TryParse(Console.ReadLine(), out x3))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //    Console.Write("Enter x3: ");
            //}
            //Console.Write("Enter y3: ");
            //while (!double.TryParse(Console.ReadLine(), out y3))
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //    Console.Write("Enter y3: ");
            //}

            //// if slope of the line passing through (x1,y1) and (x2,y2) is same as the one of the line passing through (x2,y2) and (x3,y3) => then lie on same line
            //if ((y2 - y1) * (x3 - x2) == (y3 - y2) * (x2 - x1)) 
            //{
            //    Console.WriteLine("The points lie on the same straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on the same straight line.");
            //}

            #endregion


            #region 18) Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows:  - If the worker completes the job within 2 to 3 hours, they are considered highly efficient.  - If the worker takes 3 to 4 hours, they are instructed to increase their speed.  - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.  - If the worker takes more than 5 hours, they are required to leave the company.  To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.

            //double timeTaken;

            //Console.Write("Enter the time in hours taken to complete the task: ");
            //while (!double.TryParse(Console.ReadLine(), out timeTaken) || timeTaken <= 0)
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid positive number for time.");
            //    Console.Write("Enter the time in hours taken to complete the task: ");
            //}

            //if (timeTaken >= 2 && timeTaken <= 3)
            //    Console.WriteLine("Highly efficient.");
            //else if (timeTaken > 3 && timeTaken <= 4)
            //    Console.WriteLine("Instructed to increase speed.");
            //else if (timeTaken > 4 && timeTaken <= 5)
            //    Console.WriteLine("Provided with training to enhance speed.");
            //else if (timeTaken > 5)
            //    Console.WriteLine("Required to leave the company.");
            //else
            //    Console.WriteLine("Time taken is less than 2 hours. More than Highly efficient.");

            #endregion


            #region 19) Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.Write("Enter a number to print an identity matrix: ");
            //if (int.TryParse(Console.ReadLine(), out int number))
            //{
            //    for (int i = 0; i < number; i++)
            //    {
            //        for (int j = 0; j < number; j++)
            //        {
            //            Console.Write((i == j ? "1\t" : "0\t"));
            //        }
            //        Console.WriteLine("");
            //    }
            //}
            //else Console.WriteLine("It's not a Vaild Number !");

            #endregion


            #region 20) Write a program in C# Sharp to find the sum of all elements of the array.

            //int arraySize;
            //Console.Write("Enter the size of the array: ");
            //while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize <= 0)
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer for the array size.");
            //    Console.Write("Enter the size of the array: ");
            //}

            //int[] numbers = new int[arraySize];

            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < arraySize; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer.");
            //        Console.Write($"Element {i + 1}: ");
            //    }
            //}

            //int sum = 0;
            //foreach (int number in numbers) sum += number;

            //Console.WriteLine($"The sum of the array elements is: {sum}");

            #endregion


            #region 21) Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.

            //int[] nums1 = [1, 2, 3, 4];
            //int[] nums2 = [2, 5, 6];

            //int m = nums1.Length, n = nums2.Length;

            //int[] nums3 = new int[n + m];
            //int p1 = 0, p2 = 0;

            //while (p1 < m && p2 < n)
            //{
            //    if (nums1[p1] <= nums2[p2]) nums3[p1 + p2] = nums1[p1++];
            //    else nums3[p1 + p2] = nums2[p2++];
            //}

            //while (p1 < m) { nums3[p1 + p2] = nums1[p1]; p1++; }
            //while (p2 < n) { nums3[p1 + p2] = nums2[p2]; p2++; }

            //for (int i = 0; i < n + m; i++) Console.Write($"{nums3[i]} ");

            #endregion


            #region 22) Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] arrayOfNumbers = { 2,3,5,2,3,4,6,2 };
            //int[] frequency = new int[100];

            //for (int i = 0; i < arrayOfNumbers.Length; i++) frequency[arrayOfNumbers[i]]++;

            //for (int i = 0; i < frequency.Length; i++) if(frequency[i] != 0) Console.WriteLine($"Frequency of {i} is {frequency[i]}");

            #endregion


            #region 23) Write a program in C# Sharp to find maximum and minimum element in an array

            //int[] numbers = { 2,5,1,3,5,10,2,3,6,7 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    for (int j = i + 1; j < numbers.Length; j++)
            //    {
            //        if (numbers[i] > numbers[j]) // then swap
            //        {
            //            numbers[i] = numbers[i] + numbers[j];
            //            numbers[j] = numbers[i] - numbers[j];
            //            numbers[i] -= numbers[j];
            //        }
            //    }
            //}

            //Console.WriteLine($"Max Element = {numbers[numbers.Length-1]}\nMin Element = {numbers[0]}");

            #endregion


            #region 24) Write a program in C# Sharp to find the second largest element in an array.

            //int[] numbers = { 10, 2, 1, 4, 5, 3, 2, 9, 4, 5, 2, 8};

            //int max = 0, previous = 0;

            //for (int i = 0; i < numbers.Length; i++) {
            //    if (numbers[i] >= max)
            //    {
            //        previous = max;
            //        max = numbers[i];
            //    }
            //    else if (numbers[i] >= previous) {
            //        previous = numbers[i];
            //    }
            //}

            //Console.WriteLine($"The second largest element in the array is: {previous}");

            #endregion


            #region 25) Consider an Array of Integer values with size N, having values as in this Example 7 0 0 0 5 6 7 5 0 7 5 3 write a program find the longest distance between Two equal cells.In this example.The distance is measured by the number Of cells- for example, the distance between the first and the fourth cell is 2(cell 2 and cell 3).  In the example above, the longest distance is between the first 7 and the 10th 7, with a distance of 8 cells, i.e.the number of cells between the 1st And the 10th 7s.  Note: -Array values will be taken from the user -If you have input like 1111111 then the distance is the number of Cells between the first and the last cell.

            //int arraySize;
            //Console.Write("Enter the size of the array: ");
            //while (!int.TryParse(Console.ReadLine(), out arraySize) || arraySize <= 0)
            //{
            //    Console.WriteLine("Invalid input. Please enter a positive integer for the array size.");
            //    Console.Write("Enter the size of the array: ");
            //}

            //int[] arrayElements = new int[arraySize];

            //for (int i = 0; i < arraySize; i++) {
            //    Console.Write($"Element {i + 1}: ");
            //    while (!int.TryParse(Console.ReadLine(), out arrayElements[i]))
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid integer.");
            //        Console.Write($"Element {i + 1}: ");
            //    }
            //}

            //int maxDist = 0;
            //for (int i = 0; i < arraySize; i++)
            //{
            //    for (int j = arraySize-1; j > i ; j--)
            //    {
            //        if (arrayElements[i] == arrayElements[j] && j - i - 1 > maxDist)
            //        {
            //            maxDist = j - i - 1;
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine($"Maximum distance is : {maxDist}");

            #endregion


            #region 26) Given a list of space separated words, reverse the order of the words. Input: this is a test Output: test a is this Input: all your base Output: base your all Input: Word Output: Word Note : Check the Split Function(Member in String Class) Output will be a Single Console.WriteLine Statement

            //Console.Write("Enter a string of words separated by spaces: ");
            //string inputString = Console.ReadLine() ?? "";

            //string[] names = inputString.Split();

            //string temp = "";

            //for (int i = 0; i < names.Length / 2; i++)
            //{
            //    temp = names[i];
            //    names[i] = names[names.Length - i - 1];
            //    names[names.Length - i - 1] = temp;
            //}

            //string answer = "";
            //for (int i = 0; i < names.Length-1; i++)
            //{
            //    answer += names[i] + " ";
            //}
            //answer += names[names.Length - 1];


            //Console.WriteLine(answer); 

            #endregion


            #region 27) Write a program to create two multidimensional arrays of same size.Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //int[,] firstArray = new int[2,2];
            //int[,] secondArray = new int[2, 2];

            //for (int i = 0; i < firstArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < firstArray.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter the number of the firstArray[{i}][{j}]: ");
            //        firstArray[i, j] = int.Parse(Console.ReadLine() ?? "0");
            //    }
            //}

            //for (int i = 0; i < secondArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < secondArray.GetLength(1); j++)
            //    {
            //        secondArray[i, j] = firstArray[i, j];
            //    }
            //}

            //Console.WriteLine("\nThe second array elements are: ");

            //for (int i = 0; i < secondArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < secondArray.GetLength(1); j++)
            //    {
            //        Console.Write($"secondArray[{i}][{j}]: {secondArray[i, j]}\t");
            //    }
            //    Console.WriteLine("");
            //}


            #endregion

            #region 28) Write a Program to Print One Dimensional Array in Reverse Order

            //int[] numbers = { 1,2,3,4,5,6,7,8,9,10 };

            //for (int i = numbers.Length - 1; i >= 0; i--) {
            //    Console.Write($"{numbers[i]} ");
            //}

            #endregion


            #endregion
        }
    }
}
