using System.Diagnostics.Metrics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1) Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            //// passing value type by value will pass just a copy of the variable content and any changes 
            /// inside the function won't affect that variable as now there
            //// are 2 varables one in the main function stack frame and another one in this called function stack frame.

            //// passing value type by reference let the function to directly access this variable in it's acutual 
            ///  location in the stack and update it's value which
            //// will affect the varable itself.

            //int x = 11, y = 22;

            //Console.WriteLine($"Before passing by value x = {x}, y = {y}");
            //SwapPassByValue(x, y);
            //Console.WriteLine($"After passing by value x = {x}, y = {y}");

            //Console.WriteLine("");

            //Console.WriteLine($"Before passing by reference x = {x}, y = {y}");
            //SwapPassByReference(ref x, ref y);
            //Console.WriteLine($"After passing by reference x = {x}, y = {y}");

            #endregion


            #region 2) Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //// passing Reference type by value -> any changes to that parameter will affect the actual sent parameter such as changing an array elements
            //// but if we assigned the passed array a totaly new array then a new refernce to a new array will be created inside the function only and 
            //// the passed array won't be affected at all.

            //// passing Reference type by refence -> any changes to that parameter will affect the actual sent parameter such as changing an array elements
            //// and if we assigned the passed array a totaly new array then a new refernce to a new array will be created inside the function and 
            //// that passed array will also change to that newly created array reference.

            //int[] array = [1, 2, 3, 4, 5];

            //Console.WriteLine($"Before Passing refernce type by value: array Hash Code : {array.GetHashCode()}");
            //Console.WriteLine($"Before Passing refernce type by value: array[0] : {array[0]}");
            //UpdateArrayPassByValue(array);
            //Console.WriteLine($"After Passing refernce type by value: array Hash Code : {array.GetHashCode()}");
            //Console.WriteLine($"After Passing refernce type by value: array[0] : {array[0]}");

            //array = [1, 2, 3, 4, 5];
            //Console.WriteLine("=========================");

            //Console.WriteLine($"Before Passing refernce type by reference: array Hash Code : {array.GetHashCode()}");
            //Console.WriteLine($"Before Passing refernce type by reference: array[0] : {array[0]}");
            //UpdateArrayPassByReference(ref array);
            //Console.WriteLine($"After Passing refernce type by reference: array Hash Code : {array.GetHashCode()}");
            //Console.WriteLine($"After Passing refernce type by reference: array[0] : {array[0]}");


            #endregion


            #region 3) Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //int x = 200, y = 10, sum, sub;

            //SumAndSubtract(x, y, out sum, out sub);

            //Console.WriteLine($"Sum = {sum}, Sub = {sub}");


            #endregion


            #region 4) Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. Output should be like Enter a number: 25 The sum of the digits of the number 25 is: 7

            //int number;
            //Console.Write("Enter a number to get the sum of it's digits: ");
            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.WriteLine("Please enter a valid Number to continue !!");
            //    Console.Write("Enter a number to get the sum of it's digits: ");
            //}

            //Console.WriteLine($"Sum Of The Individual Digits of {number} is {SumOfTheIndividualDigits(number)}");

            #endregion


            #region 5) Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //int number;
            //Console.Write("Enter a number to check if it's prime or not: ");
            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.WriteLine("Please enter a valid Number to continue !!");
            //    Console.Write("Enter a number to check if it's prime or not: ");
            //}

            //Console.WriteLine(IsPrime(number) ? $"{number} is prime" : $"{number} is not prime");

            #endregion


            #region 6) Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //int[] array = [100, 50, 30, 10, 60, 20, 15, 40];
            //int min = 0, max = 0;

            //MinMaxArray(array, ref min, ref max);

            //Console.WriteLine($"min = {min}, max = {max}");


            #endregion


            #region 7) Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //int result = GetFactorial(4);
            //Console.WriteLine($"The Factorial is: " + (result == -1 ? "Enter a non negative number please !!" : result));

            //result = GetFactorial(-4);
            //Console.WriteLine($"The Factorial is: " + (result == -1 ? "Enter a non negative number please !!" : result));

            #endregion


            #region 8) Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            //StringBuilder name = new StringBuilder("Ahmed Sanad");
            //Console.WriteLine($"Before changing => {name}");
            //ChangeChar(name, 3, 'X');
            //Console.WriteLine($"After changing => {name}");


            //string name1 = "Ahmed Sanad";
            //Console.WriteLine($"Before changing => {name1}");
            //ChangeCharWithoutStringBuilder(ref name1, 3, 'Z');
            //Console.WriteLine($"After changing => {name1}");

            #endregion
        }
        static void SwapPassByValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        static void SwapPassByReference(ref int x, ref int y) {
            int temp = x;
            x = y;
            y = temp;
        }

        static void UpdateArrayPassByValue(int[] array)
        {
            array[0] = 111;
            array = [100, 200, 300, 400, 500];
            Console.WriteLine($"HashCode of the newly created array inside the function: {array.GetHashCode()}");
        }
        static void UpdateArrayPassByReference(ref int[] array)
        {
            array[0] = 111;
            array = [100, 200, 300, 400, 500];
            Console.WriteLine($"HashCode of the newly created array inside the function: {array.GetHashCode()}");
        }

        static void SumAndSubtract(int number_1, int number_2, out int sumResult, out int subtractResult) {
            sumResult = number_1 + number_2;
            subtractResult = number_1 - number_2;
        }

        static int SumOfTheIndividualDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            else if (number == 2) return true;
            else if ((number % 2) == 0) return false;

            for (int i = 3; i*i <= number; i+=2)
                if (number % i == 0) { return false; }
            return true;
        }

        static void MinMaxArray(int[] numbers, ref int min, ref int max) 
        {
            min = numbers[0];
            max = numbers[0];

            for (int i = 1; i < numbers.Length; i++) { 
                if (numbers[i] < min) min = numbers[i];
                if (numbers[i] > max) max = numbers[i];
            }
        }

        static int GetFactorial(int number)
        {
            if(number < 0) { return -1; }

            int factorial = 1;

            for(int i = 1; i <= number; i++)
                factorial *= i;

            return factorial;
        }

        static void ChangeChar(StringBuilder name, int position, char newChar)
        {
            name[position] = newChar;
        }
        static void ChangeCharWithoutStringBuilder(ref string name, int position, char newChar)
        {
            name = new string(name.Substring(0, position) + $"{newChar}" + name.Substring(position+1));
        }

    }
}
