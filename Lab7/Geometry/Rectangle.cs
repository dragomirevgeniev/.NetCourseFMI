using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace Geometry
{
    public class Rectangle : Point
    {
        private Point lowerRightPoint;

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="rightPoint"></param>
        /// <param name="leftPoint"></param>
        #region Constructors
        public Rectangle(Point leftPoint, Point rightPoint) : base(leftPoint)
        {
            LowerRightPoint = rightPoint;
        }

        public Rectangle() : this(new Point(), new Point()) { }

        public Rectangle(Rectangle rec) : this(rec.UpperLeftPoint, rec.lowerRightPoint) { }
        #endregion

        /// <summary>
        /// Properties
        /// </summary>
        #region Properties
        public Point UpperLeftPoint
        {
            get
            {
                return new Point(Coords);
            }
            set
            {
                if (value != null)
                {
                    Coords = value.Coords;
                }
                else
                {
                    Coords = new int[2];
                }
            }
        }

        public Point LowerRightPoint
        {
            get
            {
                return lowerRightPoint;
            }
            set
            {
                if (value != null)
                {
                    lowerRightPoint = new Point(value);
                }
                else
                {
                    lowerRightPoint = new Point();
                }
            }
        }
        #endregion

        public virtual double Area()
        {
            return Math.Abs((Coords[0] - lowerRightPoint.Coords[0]) * (Coords[1] - lowerRightPoint.Coords[1]));
        }
        public override string ToString()
        {
            return string.Format("Rectangle [{0}, {1}]", base.ToString(), lowerRightPoint);
        }
    }
}
