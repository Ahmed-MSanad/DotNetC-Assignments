using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1.First_Project
{
    public class Point3D : IComparable, ICloneable
    {
        public decimal x { get; set; }
        public decimal y { get; set; }
        public decimal z { get; set; }

        public Point3D(decimal x, decimal y, decimal z) { 
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString() {
            return $"Point Coordinates: ({x}, {y}, {z})";
        }

        public int CompareTo(object? obj)
        {
            Point3D point = (Point3D)obj;

            if (x < point.x) return -1;
            else if (x > point.x) return 1;
            else
            {
                if (y < point.y) return -1;
                else if (y > point.y) return 1;
                else
                {
                    if (z < point.z) return -1;
                    else if (z > point.z) return 1;
                    else return 0;
                }
            }
        }

        public object Clone()
        {
            return new Point3D(x, y, z);
        }

    }
}
