using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace GeometryTests
{
    public static class RectangleExtensions
    {
        public static double CircleArea(this Rectangle rectangle)
        {
            // diameter = sqrt( (xA − xB)^2 + (yA − yB)^2 )
            double circleDiameter = Math.Sqrt((Math.Pow(rectangle.Points[0].Coordinates[0]- rectangle.Points[1].Coordinates[0], 2)) + 
                                              (Math.Pow(rectangle.Points[0].Coordinates[1] - rectangle.Points[1].Coordinates[1], 2)));
            return Math.PI * Math.Pow(circleDiameter / 2, 2);
        }
    }
}
