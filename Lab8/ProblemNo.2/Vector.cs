using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo._2
{
    public struct Vector : Comparable
    {
        private Point point;
        private Point endPoint;

        public double this[string index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Vector(Point p1, Point p2)
        {
            point = p1;
            endPoint = p2;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.point, v2.endPoint);
        }

        public static double operator *(Vector v1, Vector v2)
        {
            double x1 = v1.endPoint.X - v1.point.X;
            double y1 = v1.endPoint.Y - v1.point.Y;
            double z1 = v1.endPoint.Z - v1.point.Z;
            double x2 = v2.endPoint.X - v2.point.X;
            double y2 = v2.endPoint.Y - v2.point.Y;
            double z2 = v2.endPoint.Z - v2.point.Z;

            return x1 * x2 + y1 * y2 + z1 * z2;
        }

        public double SizeOf()
        {
            return Math.Sqrt((Math.Pow(point.X - endPoint.X, 2)) +
                             (Math.Pow(point.Y - endPoint.Y, 2)) +
                             (Math.Pow(point.Z - endPoint.Z, 2)));
        }
        public override string ToString()
        {
            return string.Format("Vector[{0}, {1}]", point, endPoint);
        }
    }
}
