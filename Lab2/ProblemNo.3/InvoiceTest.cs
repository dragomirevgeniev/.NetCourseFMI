using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemNo._3
{
    class InvoiceTest
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("Books", "12a3", 12, 5);
            Invoice invoice2 = new Invoice("Carrots", "12a5", 0.2m, -2);

            Console.WriteLine("Invoice Amount of invoice1: {0}", invoice1.GetInvoiceAmount());
            Console.WriteLine("Invoice Amount of invoice2: {0}", invoice2.GetInvoiceAmount());
        }
    }
}
