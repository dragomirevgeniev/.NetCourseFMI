using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    public class Rational
    {
        private int numerator; // holds the numerator of the rational number
        private int denominator; // holds the denominator of the rational number

        /// <summary>
        /// Properties
        /// </summary>
        #region Properties
        public int Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value != 0)
                {
                    denominator = value;
                }
            }
        }
        #endregion 

        /// <summary>
        /// Constructors
        /// </summary>
        /// <param name="numerator">Stands for the numerator of the rational number</param>
        /// <param name="denominator">Stands for the denominator of the rational number</param>
        #region Constructors
        public Rational(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }

        public Rational() : this(1, 1)
        {
            Simplify();
        }

        public Rational(Rational rational) : this(rational.Numerator, rational.Denominator)
        {
            Simplify();
        }
        #endregion

        private void Simplify()
        {
            int rem;
            int a = numerator;
            int b = denominator;
            while (b != 0)
            {
                rem = a % b;
                a = b;
                b = rem;
            }

            numerator /= a;
            denominator /= a;
        }

        #region AritmeticOperations
        public static Rational operator +(Rational rational1, Rational rational2)
        {
            int resultingDenominator = rational1.denominator * rational2.denominator;
            int resultingNumerator = rational1.numerator * rational2.denominator +
                rational1.denominator * rational2.numerator;

            return new Rational(resultingNumerator, resultingDenominator);
        }

        public static Rational operator -(Rational rational1, Rational rational2)
        {
            int resultingDenominator = rational1.denominator * rational2.denominator;
            int resultingNumerator = rational1.numerator * rational2.denominator -
                rational1.denominator * rational2.numerator;

            return new Rational(resultingNumerator, resultingDenominator);
        }

        public static Rational operator *(Rational rational1, Rational rational2)
        {
            int resultingNumerator = rational1.numerator * rational2.numerator;
            int resultingDenominator = rational1.denominator * rational2.denominator;
                
            return new Rational(resultingNumerator, resultingDenominator);
        }

        public static Rational operator /(Rational rational1, Rational rational2)
        {
            int resultingNumerator = rational1.numerator * rational2.denominator;
            int resultingDenominator = rational1.denominator * rational2.numerator;

            return new Rational(resultingNumerator, resultingDenominator);
        }
        #endregion

        public double Format(int precision)
        {
            return Math.Round((double)numerator / (double)denominator, precision);
        }

        public override string ToString()
        {
            if (denominator == 1)
            {
                return string.Format("{0}", numerator);
            }

            return string.Format("{0}/{1}", numerator, denominator);
        }
    }
}
