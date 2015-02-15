/* Task 3. A parking garage charges a $2.00 minimum fee to park for up to three hours.
 *         The garage charges an additional $0.50 per hour for each hour or part thereof
 *         in excess of three hours. The maximum charge for any given 24-hour period is $10.00.
 *         Assume that no car parks for longer than 24 hours at a time.
 *         
 *         Write an application that calculates and displays the parking charges for
 *         each customer who parked in the garage yesterday. You should enter the hours
 *         parked for each customer. The application should display the charge for the
 *         current customer and should calculate and display the running total of
 *         yesterday’s receipts. The application should use method CalculateCharges to
 *         determine the charge for each customer.
 */

using System;

class ParkinigGarageFee
{
    static void Main()
    {
        // Fee per hour up to 3 hours
        const decimal fee = 2m;

        // Addintional fee after 3 hours
        const decimal additionalFee = 0.5m;

        // Reads the number of customers
        Console.Write("Please, enter the number of customers: ");
        int numberOfCustomers = int.Parse(Console.ReadLine());

        // Calcualtes and prints the parking charges for each one customer
        decimal totalReceipts = 0;
        for (int i = 0; i < numberOfCustomers; i++)
        {
            decimal charge = CalculateCharges(fee, additionalFee, i);
            totalReceipts = totalReceipts + charge;
            Console.WriteLine("The current charge is: ${0}", charge);
        }

        Console.WriteLine("\nThe total amount of receipts are: ${0}", totalReceipts);
    }

    // Calculates the parking charges
    static decimal CalculateCharges(decimal fee, decimal additionalFee, int i)
    {
        int hours;
        while (true)
        {
            Console.Write("Enter the hours of parking per customer {0}: ", i + 1);
            hours = int.Parse(Console.ReadLine());

            if (hours < 0 && hours > 24)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please, enter correct value!");
                Console.ResetColor();
            }
            else break;
        }

        decimal charge;
        if (hours > 0 && hours <= 3)
        {
            charge = fee;
        }
        else if (hours > 3)
        {
            charge = fee + (hours - 3) * additionalFee;
            if (charge >= 10)
            {
                charge = 10;
            }
        }
        else
        {
            charge = 0;
        }

        return charge;
    }
}