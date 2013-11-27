namespace DeliveryServices
{
    class OvernightPackage : Package
    {
        // Property
        public decimal AdditionalFee { get; set; }

        // Constructor
        public OvernightPackage(string name, string address, string city, string state, uint zip, decimal weight, decimal cost, decimal additionalFee)
            : base(name, address, city, state, zip, weight, cost)
        {
            this.AdditionalFee = additionalFee;
        }

        // Redefine the calculated cost
        public override decimal CalculateCost()
        {
            return base.Weight * (base.Cost + this.AdditionalFee);
        }
    }
}
