using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIPCodeEncoding
{
    public class BarcodeEncoder
    {
        private string[] barcodes;

        public BarcodeEncoder()
        {
            barcodes = new string[10] {"||:::",
                                       ":::||",
                                       "::|:|",
                                       "::||:",
                                       ":|::|",
                                       ":|:|:",
                                       ":||::",
                                       "|:::|",
                                       "|::|:",
                                       "|:|::"};
        }

        public string PrintBarcode(string barcode)
        {
            string encodedBarcode = "";
            char[] charsOfBarcode = barcode.ToCharArray();

            for (int i = 0; i < charsOfBarcode.Length; i++)
            {
                if (charsOfBarcode[i] > '0' && charsOfBarcode[i] <= '9')
                {
                    Console.Write(barcodes[charsOfBarcode[i] - '0']);
                }
            }

            Console.WriteLine();
            return encodedBarcode = new string(charsOfBarcode);
        }
    }
}
