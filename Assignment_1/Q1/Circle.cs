using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Q1
{
    internal class Circle : ICircle
    {
        public double Area { get; set; }
        public double Radius { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"This is a Circle and it's Radius is: {Radius} , and it's Area is: {Area}");
        }

        public void SetShapeArea()
        {
            Area = Math.PI * Radius * Radius;
        }
    }
}
