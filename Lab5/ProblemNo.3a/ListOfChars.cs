using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo._3a
{
    public class ListOfChars
    {
        public static void Main(string[] args)
        {
            const int LIST_SIZE = 30;
            Stopwatch sw = new Stopwatch();
            Random rand = new Random();
            List<char> list = new List<char>();

            sw.Start();
            for (int i = 0; i < LIST_SIZE; i++)
            {
                list.Add((char)('A' + rand.Next(26)));
            }
            sw.Stop();
            Console.WriteLine("ELAPSED TIME: {0}", sw.ElapsedMilliseconds);

            var sortedAscending = list.OrderBy(c => c);
            var sortedDescending = list.OrderByDescending(c => c);
            var sortedAscendingUnique = sortedAscending.Distinct();

            // printing all chars in list sortedAscending
            foreach (var item in sortedAscending)
            {
                Console.Write(" {0}", item);
            }
            Console.WriteLine();

            // printing all chars in list sortedDescending
            foreach (var item in sortedDescending)
            {
                Console.Write(" {0}", item);
            }
            Console.WriteLine();

            // printing all chars in list sortedAscendingUnique
            foreach (var item in sortedAscendingUnique)
            {
                Console.Write(" {0}", item);
            }
            Console.WriteLine();
           
            // parallel for 
            Parallel.For(0, list.Count, c => Console.WriteLine("Char {0}", list[c]));

            // parallel foreach
            Parallel.ForEach(list, c => Console.WriteLine("Char {0}", c));
        }
    }
}
