using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Q1
{
    internal interface IShape
    {
        public double Area { get; set; }
        public void DisplayShapeInfo();
        public void SetShapeArea();
    }
}
