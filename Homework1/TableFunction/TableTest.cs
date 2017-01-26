using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableFunction
{
    class TableTest : Table
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());

            Table function;

            if (begin > end)
            {
                function = new Table(end, begin, period);
            }
            else
            {
                function = new Table(begin, end, period);
            }

            function.MakeTable();
        }
    }
}
