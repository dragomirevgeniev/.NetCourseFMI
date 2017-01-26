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
        public static void Main(string[] args)
        {
            Point p1 = new Point(new int[] { 0, 3 });
            Point p2 = new Point(new int[] { 3, 0 });
            Rectangle rec = new Rectangle(p1, p2);
            Parallelepiped ppd = new Parallelepiped(rec, 3.0);
            Console.WriteLine("{0} perimeter = {1}", rec, rec.Perimeter());
            Console.WriteLine("{0} volume = {1}", ppd, ppd.Volume());
        }
    }
}
