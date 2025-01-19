using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Q1
{
    internal interface IRectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
