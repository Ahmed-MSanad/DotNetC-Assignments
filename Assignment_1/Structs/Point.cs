using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.Structs
{
    internal struct Point
    {
        double x;
        double y;

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value < double.MaxValue && value > double.MinValue ? value : 0;
            }
        }
        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value < double.MaxValue && value > double.MinValue ? value : 0;
            }
        }


        public double GetDistance(Point p)
        {
            return Math.Sqrt(Math.Pow(p.X - X, 2) + Math.Pow(p.Y - Y, 2));
        }
    }
}
