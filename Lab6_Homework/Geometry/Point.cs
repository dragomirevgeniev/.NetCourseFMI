using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Point
    {
        private int[] coordinates; // private field which stores the x and y coordinate of the point

        /// <summary>
        /// Properties
        /// </summary>
        public int[] Coordinates
        {
            get
            {
                int[] temp = new int[2] { coordinates[0], coordinates[1] };
                return temp;
            }
            set
            {
                if (value != null && value.Length == 2)
                {
                    coordinates = new int[2] { value[0], value[1] };
                }
                else
                {
                    coordinates = new int[2];
                }
            }
        }

        /// <summary>
        /// Constructors
        /// </summary>
        #region Constructors
        public Point(int[] coordinates)
        {
            Coordinates = coordinates;
        }

        public Point() : this(new int[2]) { }

        public Point(Point point) : this(point.coordinates) { }
        #endregion

        public override string ToString()
        {
            return string.Format("Point({0}, {1})", coordinates[0], coordinates[1]);
        }
    }
}
