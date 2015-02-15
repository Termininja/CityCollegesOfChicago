using System;

public class Package
{
    private decimal weight;
    private decimal cost;

    public Package(string name, string address, string city, string state, uint zip, decimal weight, decimal cost)
    {
        this.Name = name;
        this.Address = address;
        this.City = city;
        this.State = state;
        this.Weight = weight;
        this.Cost = cost;
    }

    public string Name { get; private set; }

    public string Address { get; private set; }

    public string City { get; private set; }

    public string State { get; private set; }

    public uint Zip { get; private set; }

    public decimal Weight
    {
        get
        {
            return this.weight;
        }
        set
        {
            if (value > 0)
            {
                this.weight = value;
            }
            else
            {
                throw new ArgumentException("The weight value is not positive.");
            }
        }
    }

    public decimal Cost
    {
        get
        {
            return this.cost;
        }
        set
        {
            if (value > 0)
            {
                this.cost = value;
            }
            else
            {
                throw new ArgumentException("The cost value is not positive.");
            }
        }
    }

    virtual public decimal CalculateCost()
    {
        var cost = this.Weight * this.Cost;

        return cost;
    }
}