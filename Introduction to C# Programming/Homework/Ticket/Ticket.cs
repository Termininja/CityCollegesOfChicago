/*
 * Task 3. Write a program Ticket.cs that will allow the user to enter
 *         actual speed limit, the speed limit at which the offender was travelling,
 *         and the number of previous tickets that person has received.
 *         The application should calculate and display how many miles over the speed limit
 *         the offender was travelling, the cost of the speeding ticket, and court cost.
 *         Use $10.00 as the amount to be charged for each mile per hour over the speed limit.
 *         The court cost should begin at $50.00 and increase by $20.00 for each subsequent
 *         offense up to the third offense (that will represent the maximum court cost).
 */

using System;

class Ticket
{
    static void Main()
    {
        // Reads the actual speed limit
        Console.Write("Enter speed limit: ");
        string mph = Console.ReadLine();
        int speedlimit = int.Parse(mph);
        Console.SetCursorPosition(19 + mph.Length, 0);
        Console.WriteLine(" mph");

        // Reads the speed limit at which the offender was travelling
        Console.Write("Enter offender's speed: ");
        string mph1 = Console.ReadLine();
        int offenderspeed = int.Parse(mph1);
        Console.SetCursorPosition(24 + mph1.Length, 1);
        Console.WriteLine(" mph");

        // Reads the number of previous tickets that person has received
        Console.Write("Enter offender's previous tickets: ");
        int previoustickets = int.Parse(Console.ReadLine());
        while (previoustickets > 3 || previoustickets < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The value of previous tickets must be less than 4!");
            Console.ResetColor();
            Console.Write("Enter offender's previous tickets: ");
            previoustickets = int.Parse(Console.ReadLine());
        }

        // Calculate and print the result
        int subtract = offenderspeed - speedlimit;
        Console.WriteLine("Over speed limit: {0} mph", subtract);
        Console.WriteLine("Cost of the speeding ticket: ${0}", subtract * 10);
        Console.WriteLine("Court cost: ${0}", 50 + 20 * previoustickets);
    }
}