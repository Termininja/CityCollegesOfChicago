using System;

namespace PayrollSystems
{
    class PieceWorker : Employee
    {
        // Properies
        public decimal Wage { get; set; }
        public int Pecies { get; set; }

        // Constructor
        public PieceWorker(string firstName, string lastName, string ssn, decimal wage, int pecies)
            : base(firstName, lastName, ssn)
        {
            this.Wage = wage;
            this.Pecies = pecies;
        }

        // Method
        public override decimal Earnings()
        {
            return this.Wage * this.Pecies;
        }
    }
}
