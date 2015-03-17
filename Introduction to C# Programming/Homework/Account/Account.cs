/* Task 11. Create the class SavingsAccount. Use the static variable annualInterestRate to store the
 *          annual interest rate for all account holders. Each object of the class contains a private
 *          instance variable savingsBalance, indicating the amount the saver currently has on deposit.
 *          
 *          Provide method CalculateMonthlyInterest to calculate the monthly interest by multiplying the
 *          savingsBalance by annualInterestRate divided by 12 — this interest should be added to savingsBalance.
 *          
 *          Provide static method ModifyInterestRate to set the annualInterestRate to a new value.
 *          
 *          Write an application to test class SavingsAccount. Create two savingsAccountobjects,
 *          saver1 and saver2, with balances of $2000.00 and $3000.00, respectively. Set annualInterestRate
 *          to 4%, then calculate the monthly interest and display the new balances for both savers.
 *          Then set the annualInterestRate to 5%, calculate the next month’s interest and display the
 *          new balances for both savers.
 */

using System;

class Account
{
    static void Main()
    {
        // Creates two saving accounts
        SavingsAccount saver1 = new SavingsAccount(2000.00m);
        SavingsAccount saver2 = new SavingsAccount(3000.00m);
        Console.WriteLine("Saving balance for 1st saver: ${0}", saver1.SavingsBalance);
        Console.WriteLine("Saving balance for 2nd saver: ${0}", saver2.SavingsBalance);

        // Sets annual interest rate to 4%
        SavingsAccount.ModifyInterestRate(4);
        Console.WriteLine("\nInterest rate: 4%");

        // Calculates the monthly interest for both savers
        Console.WriteLine("New saving balance for 1st saver: ${0:F}", saver1.CalculateMonthlyInterest());
        Console.WriteLine("New saving balance for 2nd saver: ${0:F}", saver2.CalculateMonthlyInterest());

        // Sets annual interest rate to 5%
        SavingsAccount.ModifyInterestRate(5);
        Console.WriteLine("\nInterest rate: 5%");

        // Calculates the monthly interest for both savers
        Console.WriteLine("New saving balance for 1st saver: ${0:F}", saver1.CalculateMonthlyInterest());
        Console.WriteLine("New saving balance for 2nd saver: ${0:F}", saver2.CalculateMonthlyInterest());
    }
}