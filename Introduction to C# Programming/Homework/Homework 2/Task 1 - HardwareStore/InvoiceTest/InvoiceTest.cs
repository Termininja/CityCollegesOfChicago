// Task 1: Create a class called Invoice that a hardware store might use to represent an invoice
//         for an item sold at the store. An Invoice should include four pieces of information
//         as either instance variables or automatic properties—a part number (type string),
//         a part description (type string), a quantity of the item being purchased (type int)
//         and a price per item (decimal). Your class should have a constructor that initializes
//         the four values. Provide a property with a get and set accessor for any instance variables.
//         For the Quantity and PricePerItem properties, if the value passed to the set accessor
//         is negative, the value of the instance variable should be left unchanged.
//         Also, provide a method named GetInvoiceAmount that calculates the invoice amount
//         (i.e., multiplies the quantity by the price per item), then returns the amount as a decimal value.
//         Write a test application named InvoiceTest that demonstrates class Invoice’s capabilities.

using System;

namespace HardwareStore
{
    class InvoiceTest
    {
        static void Main()
        {
            // Test 1: Define and print the items
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Test 1");
            Console.ResetColor();
            Invoice item1 = new Invoice("AB788723", "Book", 78, 2.66m);
            Invoice item2 = new Invoice("AC793333", "Pencil", 13, 1.80m);
            Invoice item3 = new Invoice("MN923753", "Notebook", 175, 3.15m);

            Print(item1);
            Print(item2);
            Print(item3);

            // Test 2: Change some parameters and print them
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Test 2");
            Console.ResetColor();
            item1.PartNumber = "AB788724";
            item1.Quantity = -12;
            item1.Price = 5m;
            Print(item1);
        }

        // Prints the result
        private static void Print(Invoice i)
        {
            Console.WriteLine("Part Number:\t{0}", i.PartNumber);
            Console.WriteLine("Descritpion:\t{0}", i.Description);
            Console.WriteLine("Quantity:\t{0}", i.Quantity);
            Console.WriteLine("Price:\t\t{0}", i.Price);
            Console.WriteLine("Invoice amount:\t{0}\n", i.GetInvoiceAmount());
        }
    }
}