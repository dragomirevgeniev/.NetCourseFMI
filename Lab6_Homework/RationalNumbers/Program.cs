using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome! This is a console application for managing rational numbers!");
            Console.WriteLine("Firstly, please enter two rational numbers...");
            int numerator1, numerator2, denominator1, denominator2;
            Console.Write("Numerator1: ");
            if (Int32.TryParse(Console.ReadLine(), out numerator1)) { }
            else { Console.WriteLine("Wrong Input!"); }
            Console.Write("Denominator1: ");
            if (Int32.TryParse(Console.ReadLine(), out denominator1)) { }
            else { Console.WriteLine("Wrong Input!"); }
            Console.Write("Numerator2: ");
            if (Int32.TryParse(Console.ReadLine(), out numerator2)) { }
            else { Console.WriteLine("Wrong Input!"); }
            Console.Write("Denominator2: ");
            if (Int32.TryParse(Console.ReadLine(), out denominator2)) { }
            else { Console.WriteLine("Wrong Input!"); }

            Rational rational1 = new Rational(numerator1, denominator1);
            Rational rational2 = new Rational(numerator2, denominator2);
            Rational currentResult = new Rational();

            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1) Add the two rational numbers.");
            Console.WriteLine("2) Subtract the two rational numbers.");
            Console.WriteLine("3) Multiply the two rational numbers.");
            Console.WriteLine("4) Divide the two Rational numbers.");
            Console.WriteLine("5) Display rational numbers.");
            Console.WriteLine("6) Display rational number in floating-point format.");
            Console.WriteLine("0) Exit.");

            string choice = "";
            while (choice != "0")
            {
                Console.Write("Choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        currentResult = rational1 + rational2;
                        Console.WriteLine("{0} + {1} = {2}", rational1, rational2, currentResult);
                        break;
                    case "2":
                        currentResult = rational1 - rational2;
                        Console.WriteLine("{0} - {1} = {2}", rational1, rational2, currentResult);
                        break;
                    case "3":
                        currentResult = rational1 * rational2;
                        Console.WriteLine("{0} * {1} = {2}", rational1, rational2, currentResult);
                        break;
                    case "4":
                        currentResult = rational1 / rational2;
                        Console.WriteLine("{0} / {1} = {2}", rational1, rational2, currentResult);
                        break;
                    case "5":
                        Console.WriteLine("Current rational numbers: {0} & {1}", rational1, rational2);
                        break;
                    case "6":
                        int precision;
                        Console.Write("Please choose the number of digits after the decimal point: ");
                        if (Int32.TryParse(Console.ReadLine(), out precision)) { }
                        else { Console.WriteLine("Wrong Input!"); }
                        Console.WriteLine("Current result = {0}", currentResult.Format(precision));
                        break;
                    case "0":
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }
            }
        }
    }
}
