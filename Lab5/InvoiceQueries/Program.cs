using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceQueries
{
    public class Program
    {
        private static Invoice[] invoices =
        {
            new Invoice(83, "Electric sander", 7, 57.98m),
            new Invoice(24, "Power saw", 18, 99.99m),
            new Invoice(7, "Sledge hammer", 11, 21.50m),
            new Invoice(77, "Hammer", 76, 11.99m),
            new Invoice(39, "Lawn mower", 3, 79.50m),
            new Invoice(68, "Screwdriver", 106, 6.99m),
            new Invoice(56, "Jig saw", 21, 11.00m),
            new Invoice(3, "Wrench", 34, 7.50m),
        };

        public static IEnumerable<string> DescriptionAndQuantity()
        {
            var invoicesQuery =
                from invoice in invoices
                let value = invoice.Quantity * invoice.Price
                select new
                {
                    invoice.PartDescription,
                    invoiceTotal = value
                };

            foreach (var item in invoicesQuery)
            {
                yield return String.Format("{0}", item);
            }
        }

        public static IEnumerable<Invoice> SortInvoicesByPartDescription()
        {
            var invoicesQuery =
                from invoice in invoices
                orderby invoice.PartDescription
                select invoice;

            return invoicesQuery;
        }

        public static IEnumerable<Invoice> SortInvoicesByPrice()
        {
            var invoicesQuery =
                from invoice in invoices
                orderby invoice.Price
                select invoice;

            return invoicesQuery;
        }

        // Lambda expressions
        public static IEnumerable<Invoice> SortInvoicesByPartDescriptionDescending()
        {
            var invoicesQuery = invoices
                .OrderByDescending(inv => inv.PartDescription)
                .Select(inv => inv);

            return invoicesQuery;
        }

        public static IEnumerable<IEnumerable<Invoice>> GroupByPriceInvoices()
        {
            var groupByInvoices =
                from invoice in invoices
                orderby invoice.Price
                group invoice by Tally(invoice) into invoiceGrp
                select invoiceGrp;

            foreach (var group in groupByInvoices)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }

            return groupByInvoices;
        }

        public static string Tally(Invoice invoice)
        {
            if (invoice.Price < 12m) return "Category: Invoice with price below 12";
            if (invoice.Price > 20m) return "Category: Invoice with price above 20";
            return "Category: Invoice with price between 12 and 20";
        }
        public static void DisplayQuery<T>(IEnumerable<T> query, string title)
        {
            Console.WriteLine(title);
            foreach (T item in query)
            {
                Console.WriteLine(item);
            }
        }

        public static void Main(string[] args)
        {
            // Sorting the invoices by part descriptions and printing them
            DisplayQuery(SortInvoicesByPartDescription(), "Sorted by Part Description");
            Console.WriteLine();
            // Sorting the invoices by part descriptions and printing them
            DisplayQuery(SortInvoicesByPrice(), "Sorted by Price");
            Console.WriteLine();
            // Grouping the invoices and printing them
            GroupByPriceInvoices();
            Console.WriteLine();
        }
    }
}
