namespace DeliveryServices
{
    class TwoDayPackage : Package
    {
        // Property
        public decimal FlatFee { get; set; }

        // Constructor
        public TwoDayPackage(string name, string address, string city, string state, uint zip, decimal weight, decimal cost, decimal flatFee)
            : base(name, address, city, state, zip, weight, cost)
        {
            this.FlatFee = flatFee;
        }

        // Redefine the calculated cost
        public override decimal CalculateCost()
        {
            return base.CalculateCost() + this.FlatFee;
        }
    }
}
