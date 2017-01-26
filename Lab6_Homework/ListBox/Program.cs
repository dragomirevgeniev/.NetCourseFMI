using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBox
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListBoxTest listbox1 = new ListBoxTest();
            Console.WriteLine(listbox1.Counter); // 0

            string[] myStrings = new string[] { "a", "b", "c", "d", "e" };
            ListBoxTest listbox2 = new ListBoxTest(myStrings); // 5
            Console.WriteLine(listbox2.Counter);

            for (int i = 0; i < listbox2.Counter; i++)
            {
                // geting the strings using the class indexer
                Console.Write("{0}", listbox2[i]); // abcde
            }

            Console.WriteLine();
        }
    }
}
