using System.Drawing;

namespace Assignment_1
{
    internal class Program
    {
        public class point
        {
            public int x, y;
        }
        static void Main(string[] args)
        {
            #region Assignment_1

            #region 1) Write a program that allows the user to enter a number then print it.
            //int number = 0;
            //Console.Write("Enter a number please: ");
            //if(!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.WriteLine("Please enter valid number!!");
            //}
            //else
            //{
            //    Console.WriteLine(number);
            //}
            #endregion


            #region 2) Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen
            //string str = "123ahmed";
            //int result = Convert.ToInt32(str);
            //// it gives an Unhandled exception and the program will crash
            //// as the string has to contain only numbers -> System.FormatException: 'The input string '123ahmed' was not in a correct format

            //// We can handle it like this so our application doesn't stop or crash.
            //Console.Write("Enter a number: ");
            //int number1 = 0;
            //bool flag = int.TryParse(Console.ReadLine(), out number1);
            //if (flag)
            //{
            //    Console.WriteLine(number1);
            //}
            //else
            //{
            //    Console.WriteLine("The string contains non-numeric characters, please use numeric characters only");
            //}
            #endregion


            #region 3) Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen.
            //double number_1 = 12.56;
            //double number_2 = 13.55;
            //double result = number_1 + number_2;
            //Console.WriteLine(result); // 26.11
            #endregion


            #region 4) Write C# program that Extract a substring from a given string.
            //string name = "Ahmed Mahmoud Sanad Abdullah";
            //Console.WriteLine(name.Substring(0, 5)); // Ahmed
            //Console.WriteLine(name.Substring(6, 7)); // Mahmoud
            //Console.WriteLine(name.Substring(13)); //  Sanad Abdullah
            #endregion


            #region 5) Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen.
            //// Integer Example
            //int num1 = 10;
            //int num2 = num1;

            //Console.WriteLine($"Initial values: num1 = {num1}, num2 = {num2}");

            //num2 = 20;

            //Console.WriteLine($"After modifying num2: num1 = {num1}, num2 = {num2}");

            //// num1 stays as it and don't affected by changing num2 as it just took it's value and not it's reference.
            #endregion


            #region 6) Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen.

            //point p1 = new point();
            //p1.x = 22;
            //p1.y = 55;
            //point p2 = new point();
            //p2.x = 77;
            //p2.y = 99;

            //Console.WriteLine($"p2_x = {p2.x} | p2_y = {p2.y}");
            //p2 = p1;
            //Console.WriteLine($"p2_x = {p2.x} | p2_y = {p2.y}");
            //p1.x = 111;
            //p1.y = 666;
            //Console.WriteLine($"p2_x = {p2.x} | p2_y = {p2.y}");

            //// as we change p1_x and p1_y -> p2_x and p2_y affected with same values as p1 and p2 now see the point at the same location in memory.


            #endregion


            #region 7) Write C# program that take two string variables and print them as one variable 
            //Console.Write("Please Enter the first string: ");
            //string str1 = Console.ReadLine() ?? "No str1";
            //Console.Write("Please Enter the second string: ");
            //string str2 = Console.ReadLine() ?? "No str2";

            //Console.WriteLine($"{str1} {str2}");
            #endregion


            #region 8)Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.

            //Console.WriteLine("Please enter the following to calculate the Interest");

            //Console.Write("The principal amount: ");
            //double principalAmount = double.Parse(Console.ReadLine() ?? "0");

            //Console.Write("The rate of interest: ");
            //double rateOfInterest = double.Parse(Console.ReadLine() ?? "0");

            //Console.Write("The time: ");
            //double time = double.Parse(Console.ReadLine() ?? "0");

            //Console.WriteLine($"The Final Interest = {(principalAmount * rateOfInterest * time) / 100}");

            #endregion


            #region 9) Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height)

            //double personWeightKG = 55.5;
            //double height = 175.5;
            //double BMI = (personWeightKG) / (height * height);

            //Console.WriteLine($"The Body Mass Index of the person of wight = {personWeightKG} and height = {height} is = {BMI}");

            #endregion


            #region 10) Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".

            //double temperature = 25.45;

            //string tempCondition = temperature < 10 ? "Just Cold" : temperature > 30 ? "Just Hot" : "Just Good";

            //Console.WriteLine($"The temperature Condition is {tempCondition}");

            #endregion


            #region 11) Write a program that takes the date from the user and displays it in various formats using string interpolation. Ex: Today’s date : 20 , 11 , 2001 Today's date : 20 / 11 / 2001 Today's date : 20 – 11 – 2001

            //Console.WriteLine("Enter Today’s date to disply in various formats please.");
            //int day, month, year;
            //Console.Write("Enter The day: ");
            //day = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Enter The month: ");
            //month = int.Parse(Console.ReadLine() ?? "0");

            //Console.Write("Enter The year: ");
            //year = int.Parse(Console.ReadLine() ?? "0");

            //DateTime date = new DateTime(year, month, day);

            //Console.WriteLine($"Today’s date : {date:dd , MM , yyyy}");
            //Console.WriteLine($"Today’s date : {date:dd / MM / yyyy}");
            //Console.WriteLine($"Today’s date : {date:dd - MM - yyyy}");

            //// or :

            //Console.WriteLine($"Today’s date : {day} , {month} , {year}");
            //Console.WriteLine($"Today’s date : {day} / {month} / {year}");
            //Console.WriteLine($"Today’s date : {day} - {month} - {year}");

            #endregion


            #region 12) What is the output of the following C# code?

            //DateTime date = new DateTime(2024, 6, 14); 

            //Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

            //// The event is on 06/14/2024 -> C is the answer

            #endregion


            #region 13) Which of the following statements is correct about the C#.NET code snippet given below?

            //int d;
            //d = Convert.ToInt32(!(30 < 20)); --> 30 < 20 is false -> !false is true -> true converted to int will be 1

            // e) A value 0 will be assigned to d.
            // f) A value 1 will be assigned to d.
            // g) A value -1 will be assigned to d.
            // h) The code reports an error.
            // i) The code snippet will work correctly if ! is replaced by Not.

            // The answer is --> f

            #endregion


            #region 14) Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13 / 2 + " " + 13 % 2); --> "6 1" -> 13/2 is integer division so the fraction part is dropped

            //a) 6.5 1
            //b) 6.5 0
            //c) 6 0
            //d) 6 1
            //e) 6.5 6.5

            // The answer is d)

            #endregion


            #region 15) What will be the output of the C# code given below?

            //int num = 1, z = 5;

            //if (!(num <= 0))
            //    Console.WriteLine(++num + z++ + " " + ++z); // --> 2 + 5 + " " + 7 --> 7 7
            //else
            //    Console.WriteLine(--num + z-- + " " + --z);

            //a) 5 6
            //b) 6 5
            //c) 6 6
            //d) 7 7

            // The answer is d) 7 7


            #endregion

            #endregion
        }
    }
}
