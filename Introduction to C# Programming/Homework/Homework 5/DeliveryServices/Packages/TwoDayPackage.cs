public class TwoDayPackage : Package
{
    public TwoDayPackage(string name, string address, string city, string state, uint zip, decimal weight, decimal cost, decimal flatFee)
        : base(name, address, city, state, zip, weight, cost)
    {
        this.FlatFee = flatFee;
    }

    public decimal FlatFee { get; set; }

    public override decimal CalculateCost()
    {
        var cost = base.CalculateCost() + this.FlatFee;

        return cost;
    }
}