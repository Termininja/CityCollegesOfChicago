using System;

class SavingsAccount
{
    // Store the annual interest rate for all account holders 
    static private decimal annualInterestRate;

    // SavingsBalance which indicates the amount the holder currently has on deposit
    public decimal SavingsBalance { get; private set; }

    public SavingsAccount(decimal savingsBalance)
    {
        this.SavingsBalance = savingsBalance;
    }

    // Method which calculate the monthly interest 
    public decimal CalculateMonthlyInterest()
    {
        return this.SavingsBalance + this.SavingsBalance * annualInterestRate / 12;
    }

    // Method which set the annualInterestRate to a new value
    static public void ModifyInterestRate(byte newRate)
    {
        annualInterestRate = newRate / 100m;
    }
}