using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rectangle
    {
        private Point[] points; // private field which stores an array of two points:
                                // the first Point element defines the upper left corner and 
                                // the second Point element defines the lower right corner of the rectangle

        /// <summary>
        /// Properties
        /// </summary>
        public Point[] Points
        {
            get
            {
                Point[] temp = new Point[2] { points[0], points[1] };
                return temp;
            }
            set
            {
                if ((value != null && value.Length == 2) && 
                    ((value[0].Coordinates[0] < value[1].Coordinates[0]) &&
                     (value[0].Coordinates[1] > value[1].Coordinates[1])))
                {
                    points = new Point[2] { value[0], value[1] };
                }
                else
                {
                    points = new Point[2] { new Point(), new Point() };
                }
            }
        }

        /// <summary>
        /// Constructors
        /// </summary>
        #region Constructors
        public Rectangle(Point[] points)
        {
            Points = points;
        }

        public Rectangle() : this(new Point[2]) { }

        public Rectangle(Rectangle rectangle) : this(rectangle.points) { } 
        #endregion

        public double Perimeter()
        {
            // ULP = Upper left point
            // LRP = Lower right point
            // 2 * ( (LRP.x - ULP.x) + (ULP.y - LRP.y) )
            //              x                 y
            return 2 * ((points[1].Coordinates[0] - points[0].Coordinates[0]) +
                        (points[0].Coordinates[1] - points[1].Coordinates[1]));
        }

        public override string ToString()
        {
            return string.Format("Rectangle[{0}, {1}]", points[0], points[1]);
        }
    }
}
