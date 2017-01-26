using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace PointRectangleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Point pointA = new Point(new int[2] { r.Next(99), r.Next(99) });
            Point pointB = new Point(new int[2] { r.Next(99), r.Next(99) });

            Rectangle rectangle = new Rectangle(r.Next(10, 20), r.Next(10, 20), pointA);
            Console.WriteLine(" -> {0}", rectangle);
            rectangle['x'] = 10;
            rectangle['y'] = 10;
            Console.WriteLine(" -> {0}", rectangle);
            Console.WriteLine("Changed lower left point of the rectangle to (11, 11)\n -> {0}", rectangle);
            rectangle.Move(pointB);
            Console.WriteLine("Moved the rectangle to new point {0}\n -> {1}", pointB, rectangle);
            List<Rectangle> list1 = new List<Rectangle>();
            List<Rectangle> list2;
            for (int i = 0; i < 5; i++)
            {
                list1.Add(new Rectangle(r.Next(10, 20), r.Next(10, 20), pointA));
            }

            list2 = Rectangle.SortByAscenidng(list1, Rectangle.Area); // sorting the rectangles by their area value

            Console.WriteLine("Sorted rectangles by their area: ");
            foreach (var item in list2)
            {
                Console.WriteLine(" -> {0}", item);
            }

            Rectangle square = new Rectangle(10, 10, new Point(new int[2] {5, 5}));
            Console.WriteLine("Is {0} a square? \n-> {1}", square, square.IsSquare());
            Console.WriteLine("Perimeter of {0} \n= {1}", square, square.Perimeter()); // expected result -> 2 * (10 + 10) = 40
            Console.WriteLine("LLP of the previous rectangle\n -> ({0}, {1})", square['x'], square['y']);
            square.Scale(2.5);
            Console.WriteLine("Scaled the same rectangle by 2.5\n -> {0}", square);
        }
    }
}
