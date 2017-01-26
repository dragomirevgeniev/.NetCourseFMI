using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeCosinus
{
    class CosinnusCompution
    {
        public const double eps = 0.001;
        private static double ComputeCosinus(double x)
        {
            double sum = 1;
            double term = 1;
            int n = 0;
            do
            {
                n++;
                term *= (-x * x) / ((2.0 * n) * (2.0 * n - 1));
                sum += term;
            } while (Math.Abs(term) > eps);

            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ComputeCosinus(Math.PI / 6));
            Console.WriteLine(Math.Cos(Math.PI / 6));
        }
    }
}
