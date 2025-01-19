using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Q1
{
    internal class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This is a Rectangle and it's Width is: {Width} , Height is: {Height} and it's Area is: {Area}");
        }
        public void SetShapeArea()
        {
            Area = Width * Height;
        }
    }
}
