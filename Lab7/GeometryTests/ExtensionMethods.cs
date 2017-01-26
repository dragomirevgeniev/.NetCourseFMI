using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace GeometryTests
{
    public static class ExtensionMethods
    {
        public static double Volume(this Parallelepiped ppd)
        {
            return ppd.Length * ppd.Width * ppd.Height;
        }

        public static double Perimeter(this Rectangle rec)
        {
            double x = Math.Abs(rec.LowerRightPoint.Coords[0] - rec.UpperLeftPoint.Coords[0]);
            double y = Math.Abs(rec.UpperLeftPoint.Coords[1] - rec.LowerRightPoint.Coords[1]);
            return 2 * (x + y);
        }
    }
}
