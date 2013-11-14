// Task 1: Write a program that inputs three integer from the user and displays
//         the sum, average, product, and smallest and largest of the numbers.

using System;

class CalculationsOf3Numbers
{
    static void Main()
    {
        // Reads the 1st integer number
        Console.Write("Enter any integer number1: ");
        int num1 = int.Parse(Console.ReadLine());

        // Reads the 2nd integer number
        Console.Write("Enter any integer number2: ");
        int num2 = int.Parse(Console.ReadLine());

        // Reads the 3rd integer number
        Console.Write("Enter any integer number3: ");
        int num3 = int.Parse(Console.ReadLine());

        // Calculate and print the sum
        int sum = num1 + num2 + num3;
        Console.WriteLine("The sum is: " + sum);

        // Calculate and print the average
        Console.WriteLine("The average is: {0}", sum / 3);

        // Calculate and print the product
        Console.WriteLine("The product is: {0}", num1 * num2 * num3);

        // Calculate and print the smallest of the numbers
        Console.WriteLine("The smallast value is: {0}", Math.Min(Math.Min(num1, num2), num3));

        // Calculate and print the largest of the numbers
        Console.WriteLine("The largest value is: {0}", Math.Max(Math.Max(num1, num2), num3));
    }
}