using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Rectangle
    {
        #region Fields
        private double length;
        private double width;
        private Point leftLowerPoint;
        private readonly string R_ID;
        private static long counter;
        #endregion

        /// <summary>
        /// Properties
        /// </summary>
        #region Properties
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value >= 0)
                {
                    length = value;
                }
                else
                {
                    length = 0;
                }
            }
        }

        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value >= 0 ? value : 0;
            }
        }

        public Point LeftLowerPoint
        {
            get
            {
                return new Point(leftLowerPoint);
            }
            set
            {
                leftLowerPoint = value != null ? new Point(value) : new Point();
            }
        }

        public string R_ID_CODE
        {
            get { return R_ID; }
        }
        #endregion

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="length">Stores the length of the rectangle</param>
        /// <param name="width">Stores the width of the rectangle</param>
        /// <param name="point">Stores the lower left point of the rectangle</param>
        #region Constructors
        public Rectangle(double length, double width, Point point)
        {
            Length = length;
            Width = width;
            LeftLowerPoint = point;
            R_ID = string.Format("{0:D6}", counter++);
        }

        public Rectangle() : this(0, 0, new Point()) { }

        public Rectangle(Rectangle rectangle) : this(rectangle.length,
                                                     rectangle.width,
                                                     rectangle.leftLowerPoint)
        { }
        #endregion

        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="index">A char representing one of the fields of the rectangle</param>
        /// <returns></returns>
        public double this[char index]
        {
            get
            {
                switch (index.ToString().ToLower())
                {
                    case "w":
                        return width;
                    case "h":
                        return length;
                    case "x":
                        return LeftLowerPoint.Coordinates[0];
                    case "y":
                        return LeftLowerPoint.Coordinates[1];
                    default:
                        return Double.MaxValue;
                }
            }
            set
            {
                switch (index.ToString().ToLower())
                {
                    case "w":
                        width = value >=0 ? value : 0;
                        break;
                    case "h":
                        length = value >= 0 ? value : 0;
                        break;
                    case "x":
                        LeftLowerPoint.Coordinates[0] = (int)value;
                        break;
                    case "y":
                        LeftLowerPoint.Coordinates[1] = (int)value;
                        break;
                }
            }
        }


        /// <summary>
        /// Utilities that the rectangle has
        /// </summary>
        /// <param name="rectangle"></param>
        /// <returns></returns>
        #region Utilities
        public static double Area(Rectangle rectangle)
        {
            return rectangle.length * rectangle.width;
        }

        public static double Diagonal(Rectangle rectangle)
        {
            return Math.Sqrt(rectangle.length * rectangle.length +
                             rectangle.width * rectangle.width);
        } 

        public static List<Rectangle> SortByAscenidng(List<Rectangle> list, CompareBy compare)
        {
            List<Rectangle> sortedList;
            sortedList = list.OrderBy(x => compare(x)).ToList<Rectangle>();

            return sortedList;
        }
        public static List<Rectangle> SortByDescenidng(List<Rectangle> list, CompareBy compare)
        {
            List<Rectangle> sortedList;
            sortedList = list.OrderByDescending(x => compare(x)).ToList<Rectangle>();

            return sortedList;
        }
        #endregion

        public override string ToString()
        {
            return string.Format("Rectangle ID:{0}[l:{1}, w:{2}, LLP:{3}, D:{4:F2}, A:{5:F2}]", R_ID, length, width, leftLowerPoint, Diagonal(this), Area(this));
        }
    }
}
