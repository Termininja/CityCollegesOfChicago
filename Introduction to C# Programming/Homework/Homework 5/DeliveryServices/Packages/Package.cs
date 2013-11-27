using System;

namespace DeliveryServices
{
    class Package
    {
        // Fields
        private decimal weight;
        private decimal cost;

        // Properties
        public decimal Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                if (value > 0) this.weight = value;
                else throw new ArgumentException("Please enter positive weight value.");
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
                if (value > 0) this.cost = value;
                else throw new ArgumentException("Please enter positive cost value.");
            }
        }

        public string Name { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public uint Zip { get; private set; }


        // Constructor
        public Package(string name, string address, string city, string state, uint zip, decimal weight, decimal cost)
        {
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Weight = weight;
            this.Cost = cost;
        }

        // Method for calculating the cost
        virtual public decimal CalculateCost()
        {
            return this.Weight * this.Cost;
        }
    }
}
