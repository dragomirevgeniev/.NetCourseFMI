using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo._2
{
    public struct Point : Comparable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double this[string index]
        {
            get
            {
                switch (index.ToLower())
                {
                    case "x":
                        return X;
                    case "y":
                        return Y;
                    case "z":
                        return Z;
                    default:
                        return Double.MaxValue;
                }
            }

            set
            {
                switch (index.ToLower())
                {
                    case "x":
                        X = value;
                        break;
                    case "y":
                        Y = value;
                        break;
                    case "z":
                        Z = value;
                        break;
                }
            }
        }

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double SizeOf()
        {
            return Math.Abs(X + Y + Z);
        }

        private static bool GetSizeOf(Comparable obj1, Comparable obj2)
        {
            return obj1.SizeOf() > obj2.SizeOf();
        }

        public static GreaterThan GetGreaterThan
        {
            get
            {
                return GetSizeOf;
            }
        }
        public override string ToString()
        {
            return string.Format("Point[{0}, {1}, {2}]", X, Y, Z);
        }
    }
}
