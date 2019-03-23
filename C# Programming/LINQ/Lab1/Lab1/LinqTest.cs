// Grading ID: Z8856
// CIS 200-01
// Due Date: Wednesday, February 7
// Lab 1
// This lab let us to play with LINQ and run queries on an array of Invoice objects
// we used the where, orderby, let clauses and created anonymous classes to sort, filter, and display 
// properties of invoice objects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
    public class LinqTest
    {
        public static void Main(string[] args)
        {
            // initialize array of invoices
            Invoice[] invoices = { 
                new Invoice( 83, "Electric sander", 7, 57.98M ), 
                new Invoice( 24, "Power saw", 18, 99.99M ), 
                new Invoice( 7, "Sledge hammer", 11, 21.5M ), 
                new Invoice( 77, "Hammer", 76, 11.99M ), 
                new Invoice( 39, "Lawn mower", 3, 79.5M ), 
                new Invoice( 68, "Screwdriver", 106, 6.99M ), 
                new Invoice( 56, "Jig saw", 21, 11M ), 
                new Invoice( 3, "Wrench", 34, 7.5M ) };

            decimal invoiceTotalUpperLimit = 500M; // upper limit for invoice total
            decimal invoiceTotalLowerLimit = 200M; // lower limit for invoice total

            // Display original array
            Console.WriteLine("Original Invoice Data\n");
            Console.WriteLine("P.Num Part Description     Quant Price"); // Column Headers
            Console.WriteLine("----- -------------------- ----- ------");

            foreach (Invoice inv in invoices) 
                Console.WriteLine(inv);

            //LINQ query to sort parts by part description
            Console.WriteLine();
            var sortByPartDescription =
                from invoice in invoices // invoice from list of invoices
                orderby invoice.PartDescription
                select invoice;

            // Display results of query
            Console.WriteLine($"Part A) Order by part description");
            foreach (var part in sortByPartDescription)
                Console.WriteLine(part);
            Console.WriteLine();

            // LINQ query that sorts invoices by price
            var sortByPrice =
                from invoice in invoices // invoice variable 
                orderby invoice.Price
                select invoice;

            // Display results of query
            Console.WriteLine($"Part B) Order by price");
            foreach (var price in sortByPrice)
                Console.WriteLine(price);
            Console.WriteLine();

            // LINQ query to select part description and quantity and sort by quantity
            var sortByQuantity =
                from invoice in invoices // invoice from list of invoices
                orderby invoice.Quantity
                select new { invoice.PartDescription, invoice.Quantity };

            // Display results of query
            Console.WriteLine("Part C) Select part description and quantity and order by quantity");
            foreach (var invoice in sortByQuantity)
                Console.WriteLine($"Part Description: {invoice.PartDescription}   Quantity: {invoice.Quantity}");
            Console.WriteLine();

            // LINQ query to select part description and the value of the invoice
            var selInvoice =
                from invoice in invoices // invoice from list of invoices
                let total = invoice.Quantity * invoice.Price
                orderby total
                select new { InvoiceTotal = total, invoice.PartDescription };

            // Display results of query
            Console.WriteLine("Part D) Select and display total invoice prices and part descriptions");
            foreach (var invoice in selInvoice)
                Console.WriteLine($"Invoice Total: {invoice.InvoiceTotal,-10:C}  Part Description: {invoice.PartDescription,-10}");
            Console.WriteLine();

            //LINQ query to select from invoice total query result between 200 and 500
            var invoiceAmountsInRange =
                from invoice in selInvoice // invoice from list of invoices
                where (invoice.InvoiceTotal <= invoiceTotalUpperLimit && invoice.InvoiceTotal >= invoiceTotalLowerLimit)
                select new { invoice.InvoiceTotal, invoice.PartDescription };

            // Display results of query
            Console.WriteLine("Part E) Select invoice totals between $200 and $500");
            foreach (var totalAmount in invoiceAmountsInRange)
                Console.WriteLine($"Invoice Total: {totalAmount.InvoiceTotal:C} {totalAmount.PartDescription, -10}");
        }
    }
}
