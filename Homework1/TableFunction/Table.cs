using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableFunction
{
    public class Table
    {
        #region Fields
        // fields: beginnig, ending and the period we like our results to be shown
        private int begin;
        private int end;
        private int period;
        #endregion

        #region Constructors
        // default constructor
        public Table()
        {
            Begin = 0;
            End = 20;
            Period = 5;
        }
        // constructor with parameters
        public Table(int begin, int end, int period)
        {
            Begin = begin;
            End = end;
            Period = period;
        }
        #endregion

        #region Properties
        public int Begin
        {
            get
            {
                return begin;
            }

            set
            {
                // no limits for the fields (except the range of the Integer)
                begin = value;
            }
        }

        public int End
        {
            get
            {
                return end;
            }

            set
            {
                // no limits for the fields (except the range of the Integer)
                end = value;
            }
        }

        public int Period
        {
            get
            {
                return period;
            }

            set
            {
                // no limits for the fields (except the range of the Integer)
                period = value;
            }
        }
        #endregion

        public void MakeTable()
        {
            int counter = 0;

            for (int i = Begin; i < End; i++)
            {
                Console.WriteLine("x={0,-3} f(x)={1:F4}", i, (Math.Abs(Math.Pow(((double)i - 2), 2))) / (Math.Pow((double)i, 2) + 1));
                counter++;
                if (counter % Period == 0)
                {
                    Console.WriteLine("Press return to continue...");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {

                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
    }
}
