namespace SalesReport
{
    class Salesperson
    {
        string NameID2 = "Salesperson 2";
        string NameID3 = "Salesperson 3";

        // Constructor
        public Salesperson(string id)
        {
            this.NameID1 = id;
        }

        // Property
        public string NameID1 { get; set; }

        public override string ToString()
        {
            return string.Format("{0,25} {1,15} {2,15} ", NameID1, NameID2, NameID3);
        }
    }
}