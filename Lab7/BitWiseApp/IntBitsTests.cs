using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitWiseApp
{
    public class IntBitsTests
    {
        public static void Main(string[] args)
        {
            int adapted = 5;
            IntBits bits = new IntBits(adapted); // 5 = 000....101
            Console.WriteLine("Bit {0} is {1}", 1, bits[1]);
            bits[1] = (bits[1])? false : true;
            Console.WriteLine("Bit {0} is {1}", 1, bits[1]);
            Console.WriteLine(bits);
        }
    }
}
