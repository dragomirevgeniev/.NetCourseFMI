using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace PointRectangleTest
{
    public static class RectangleExtensions
    {
        public static double Perimeter(this Rectangle rectangle)
        {
            return 2 * (rectangle.Length + rectangle.Width);
        }

        public static bool IsSquare(this Rectangle rectangle)
        {
            return (rectangle.Length == rectangle.Width);
        }

        public static void Move(this Rectangle rectangle, Point point)
        {
            rectangle.LeftLowerPoint = point;
        }

        public static void Scale(this Rectangle rectangle, double scale)
        {
            rectangle.Width *= scale;
            rectangle.Length *= scale; 
        }
    }
}
