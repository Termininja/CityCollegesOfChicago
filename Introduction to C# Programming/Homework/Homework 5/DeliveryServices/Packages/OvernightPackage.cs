public class OvernightPackage : Package
{
    public OvernightPackage(string name, string address, string city, string state, uint zip, decimal weight, decimal cost, decimal additionalFee)
        : base(name, address, city, state, zip, weight, cost)
    {
        this.AdditionalFee = additionalFee;
    }

    public decimal AdditionalFee { get; set; }

    public override decimal CalculateCost()
    {
        var cost = base.Weight * (base.Cost + this.AdditionalFee);

        return cost;
    }
}