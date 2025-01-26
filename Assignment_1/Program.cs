using System.Diagnostics;
using Assignment_1.Project_one.Q1;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Proj 1
            // 1) Define Class Duration To include Three Attributes Hours, Minutes and Seconds: -> Done

            // 2) Override All System.Object Members (ToString, Equals,GetHasCode): -> Done

            // 3) Define All Required Constructors to Produce this output:

            Duration D11 = new Duration(1, 10, 15);
            Console.WriteLine($"D11 => {D11.ToString()}");

            Duration D1 = new Duration(3600);
            Console.WriteLine($"D1 => {D1.ToString()}");

            Duration D2 = new Duration(7800);
            Console.WriteLine($"D2 => {D2.ToString()}");

            Duration D3 = new Duration(666);
            Console.WriteLine($"D3 => {D3.ToString()}");

            // 4) Implement All required Operators overloading to enable this Code:

            D3 = D1 + D2;
            Console.WriteLine($"D3 => {D3.ToString()}");
            D3 = D1 + null;
            Console.WriteLine($"D3 => {D3.ToString()}");
            D3 = null + D2;
            Console.WriteLine($"D3 => {D3.ToString()}");

            D3 = D1 + 7800;
            Console.WriteLine($"D3 => {D3.ToString()}");

            D3 = 666 + D3;
            Console.WriteLine($"D3 => {D3.ToString()}");

            D3 = ++D1; // (Increase One Minute)
            Console.WriteLine($"D3 => {D3.ToString()} and new D1 is D1: {D1.ToString()}");

            D3 = --D2; // (Decrease One Minute)
            Console.WriteLine($"D3 => {D3.ToString()} and new D2 is D2: {D2.ToString()}");

            D1 = D1 - D2;
            Console.WriteLine($"D1 => {D1.ToString()}");

            if(D1 > D2){
                Console.WriteLine($"D1: {D1.ToString()} is greater than D2: {D2.ToString()}");
            }
            else
            {
                Console.WriteLine($"D1: {D1.ToString()} is not greater than D2: {D2.ToString()}");
            }

            if(D1 <= D2){
                Console.WriteLine($"D1: {D1.ToString()} is less than or equal D2: {D2.ToString()}");
            }
            else
            {
                Console.WriteLine($"D1: {D1.ToString()} is not less than or equal D2: {D2.ToString()}");
            }

            if(D1){
                Console.WriteLine($"D1 => {D1.ToString()} -> is Not Zero Duration.");
            }
            else
            {
                Console.WriteLine($"D1 => {D1.ToString()} -> is Zero Duration.");
            }

            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj);


            // Cases Should be handled:
            Console.WriteLine($"==================================== Extra Cases I handled them: ====================================");
            D1 = new Duration(1, 0, 0);
            Console.WriteLine($"D1 => {D1.ToString()}");
            --D1;
            Console.WriteLine($"D1 => {D1.ToString()}");


            Console.WriteLine("================== ===================");
            D1 = new Duration(0, 0, 4);
            Console.WriteLine($"D1 => {D1.ToString()}");
            try { 
                --D1;
                Console.WriteLine($"D1 => {D1.ToString()}");
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.WriteLine("================== ===================");
            D1 = new Duration(0, 59, 0);
            Console.WriteLine($"D1 => {D1.ToString()}");
            ++D1;
            Console.WriteLine($"D1 => {D1.ToString()}");


            Console.WriteLine("================== ===================");
            D1 = null;
            try
            {
                Obj = (DateTime)D1;
                Console.WriteLine(Obj);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



            #endregion
        }
    }
}
