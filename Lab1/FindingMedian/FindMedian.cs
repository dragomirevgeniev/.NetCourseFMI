using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class FindingMedian
    {
        static void Main(string[] args)
        {
            // Declarations
            double num1, num2, num3, median;

            // Initializations
            Console.Write("Enter your first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter your second number: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Write("Enter your third number: ");
            num3 = double.Parse(Console.ReadLine());

            median = FindMedian(num1, num2, num3);

            // Output
            Console.WriteLine("The median is: {0}", median);
        }

        // Function that finds the median of three numbers
        static double FindMedian(double num1, double num2, double num3)
        {
            if ((num2 < num1 && num1 < num3) || (num2 > num1 && num1 > num3))
            {
                return num1;
            }

            if ((num1 < num2 && num2 < num3) || (num1 > num2 && num2 > num3))
            {
                return num2;
            }

            return num3;
        }
    }
}