using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Parallelepiped : Rectangle
    {
        private double height;

        /// <summary>
        /// Properties
        /// </summary>
        #region Properties
        public double Length
        {
            get
            {
                return Math.Abs(base.UpperLeftPoint.Coords[0] - base.LowerRightPoint.Coords[0]);
            }
            set
            {
                if (value >= 0)
                {
                    base.UpperLeftPoint.Coords[0] += (int)value;
                }
                else
                {
                    base.LowerRightPoint.Coords[0] = base.UpperLeftPoint.Coords[0];
                }
            }
        }

        public double Width
        {
            get
            {
                return Math.Abs(base.UpperLeftPoint.Coords[1] - base.LowerRightPoint.Coords[1]);
            }
            set
            {
                if (value >= 0)
                {
                    base.LowerRightPoint.Coords[1] += (int)value;
                }
                else
                {
                    base.LowerRightPoint.Coords[1] = base.UpperLeftPoint.Coords[1];
                }
            }
        }

        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = (value >= 0) ? value : 0.0; 
            }
        }
        #endregion

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="rectangle"></param>
        /// <param name="heigth"></param>
        #region Constructors
        public Parallelepiped(Rectangle rectangle, double height) : base(rectangle)
        {
            Height = height;
        }

        public Parallelepiped() : this(new Rectangle(), 0) { }

        public Parallelepiped(Parallelepiped ppd) : this(new Rectangle(ppd.UpperLeftPoint, ppd.LowerRightPoint), ppd.height) { }
        #endregion

        public override double Area()
        {
            return 2 * (base.Area() + Length * height + Width + height);
        }

        public override string ToString()
        {
            return string.Format("PPD [{0}, {1}]", base.ToString(), height);
        }
    }
}
