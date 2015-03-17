// Task 2: A website sells three products whose retail prices are as follows:
//         Product 1, $2.98; product 2, $4.50; and product 3, $9.98.
//         Write an application that reads a series of pairs of numbers as follows:
//             a) product number
//             b) quantity sold
//         Your application should use a switch statement to determine the retail price
//         for each product. It should calculate and display the total retail value
//         of all products sold. Use a sentinel-controlled loop to determine when
//         the application should stop looping and display the final results.

using System;

class SellsThreeProducts
{
    static void Main()
    {
        decimal finalResult = 0;
        while (true)
        {
            // Reads the number of the product
            Console.Write("Enter the number of product: ");
            int numberOfProduct = int.Parse(Console.ReadLine());

            // Reads the quantitiy of that product
            Console.Write("Enter the quantitiy of this product: ");
            int quantity = int.Parse(Console.ReadLine());

            switch (numberOfProduct)
            {
                case 1:
                    finalResult += quantity * 2.98m;
                    break;
                case 2:
                    finalResult += quantity * 4.5m;
                    break;
                case 3:
                    finalResult += quantity * 9.98m;
                    break;
                default:
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Do you want to continue (y/n):\n");
            Console.ResetColor();
            ConsoleKeyInfo readkey = Console.ReadKey();
            while (readkey.Key != ConsoleKey.N && readkey.Key != ConsoleKey.Y)
            {
                Console.Write("\b \b");
                readkey = Console.ReadKey();
            }

            if (readkey.Key == ConsoleKey.N) break;
            Console.Write("\b \b");
        }

        // Prints the final result
        Console.WriteLine("\b \bTotal price: {0}", finalResult);
    }
}