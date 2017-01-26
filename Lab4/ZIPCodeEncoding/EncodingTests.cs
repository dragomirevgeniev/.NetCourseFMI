using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIPCodeEncoding
{
    class EncodingTests
    {
        static void Main(string[] args)
        {
            BarcodeEncoder encoder = new BarcodeEncoder();
            string inputBarcode = Console.ReadLine();
            Console.WriteLine("Barcode: {0}", inputBarcode);
            Console.Write("Encoded barcode: ");
            encoder.PrintBarcode(inputBarcode);
        }
    }
}
