using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo._2
{
    public struct Triangle : Comparable
    {
        private Vector vectorA;
        private Vector vectorB;

        public Triangle(Vector v1, Vector v2)
        {
            vectorA = v1;
            vectorB = v2;
        }

        public double this[string index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public double SizeOf()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Format("Triagnle[{0}, {1}]", vectorA, vectorB);
        }

    }
}
