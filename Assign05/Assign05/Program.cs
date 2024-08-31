using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Reflection;

namespace Assign05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list of Invoice objects with initialized sample data
            List<Invoice> invoicesList = new List<Invoice>
            {
                new Invoice(83, "Electric sander", 7, 57.88m),
                new Invoice(24, "Power saw", 18, 99.99m),
                new Invoice(7, "Sledge hammer", 11, 21.50m),
                new Invoice(77, "Hammer", 76, 11.99m),
                new Invoice(39, "Lawn mower", 3, 79.50m),
                new Invoice(68, "Screwdriver", 106, 6.99m),
                new Invoice(56, "Jig saw", 21, 11.00m),
                new Invoice(3, "Wrench", 34, 7.50m)
            };

            //LINQ to sort Invoice objects by Part Description
            var queryToSortByPartDescription = from invoice in invoicesList
                                               orderby invoice.PartDescription
                                               select invoice;

            Console.WriteLine("Sorted the Invoice objects by Part Description:\n");

            foreach (Invoice item in queryToSortByPartDescription)
            {
                Console.WriteLine(item);
            }

            //LINQ to sort Invoice objects by Price
            var queryToSortByPrice = from invoice in invoicesList
                                               orderby invoice.Price
                                               select invoice;

            Console.WriteLine("\nSorted the Invoice objects by Price:\n");

            foreach (Invoice item in queryToSortByPrice)
            {
                Console.WriteLine(item);
            }

            //LINQ to select Part Description and Quantity and sort by Quantity
            var queryToSortByQuantity = from invoice in invoicesList
                                        orderby invoice.Quantity
                                        select new {invoice.PartDescription, invoice.Quantity};

            Console.WriteLine("\nSorted the Invoice objects by Quantity and selected Part Description and Quantity:\n");

            foreach (var item in queryToSortByQuantity)
            {
                Console.WriteLine($"{item.PartDescription,-20} {item.Quantity,-5}");
            }

            //LINQ to select Part Description and total value of each invoice
            var queryToSelectPartDescAndValue = from invoice in invoicesList
                                                let total = invoice.Quantity * invoice.Price 
                                                select new {invoice.PartDescription, total};

            Console.WriteLine("\nSelected Part Description and total of each Invoice:\n");

            foreach (var item in queryToSelectPartDescAndValue)
            {
                Console.WriteLine($"{item.PartDescription,-20} {item.total,-5}");
            }

            //LINQ to select invoiceTotals in range $200-$500
            var queryToSelectRangeInvoiceTotal = from invoiceTotals in queryToSelectPartDescAndValue
                                            where invoiceTotals.total >= 200 && invoiceTotals.total <= 500
                                            select invoiceTotals;

            Console.WriteLine("\nSelected Invoice totals between the range $200 and $500:\n");
            
            foreach (var item in queryToSelectRangeInvoiceTotal)
            {
                Console.WriteLine($"{item.PartDescription,-20} {item.total,-5}");
            }
        }
    }
}