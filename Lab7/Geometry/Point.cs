using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Point
    {
        private int[] coords;

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="coords"></param>
        #region Constructors
        public Point(int[] coords)
        {
            Coords = coords;
        }

        public Point() : this(new int[2]) { }

        public Point(Point point) : this(point.Coords) { }
        #endregion

        /// <summary>
        /// Properties
        /// </summary>
        public int[] Coords
        {
            get
            {
                return new int[] { coords[0], coords[1] };
            }
            set
            {
                if ((value != null) && (value.Length == 2))
                {
                    coords = new int[] { value[0], value[1] };
                }
                else
                {
                    coords = new int[2];
                }
            }
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", coords[0], coords[1] );
        }
    }
}
