using System;

class PieceWorker : Employee
{
    public PieceWorker(string firstName, string lastName, string ssn, decimal wage, int pecies)
        : base(firstName, lastName, ssn)
    {
        this.Wage = wage;
        this.Pecies = pecies;
    }

    public decimal Wage { get; set; }

    public int Pecies { get; set; }

    public override decimal Earnings()
    {
        var result = this.Wage * this.Pecies;

        return result;
    }
}