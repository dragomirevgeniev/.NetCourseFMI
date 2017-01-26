using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace GeometryTests
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new Point(new int[] { 1, 3 });
            Point pointC = new Point(new int[] { 4, 1 });

            Rectangle rectangle = new Rectangle(new Point[] { pointA, pointC });
            Console.WriteLine("{0} had been created!\n -> Perimeter = {1}\n -> Circle Area = {2}", 
                rectangle, rectangle.Perimeter(), rectangle.CircleArea());
        }
    }
}
