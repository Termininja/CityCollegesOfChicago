namespace SalesReport
{
    public class Pay1
    {
        decimal name1 = 30.10m;
        decimal name2 = 70.05m;
        decimal name3 = 10.80m;

        public override string ToString()
        {
            return string.Format("{0,25:C} {1,15:C} {2,15:C} ", name1, name2, name3);
        }
    }

    class Pay2
    {
        decimal name1 = 40.00m;
        decimal name2 = 1.00m;
        decimal name3 = 2.25m;

        public override string ToString()
        {
            return string.Format("{0,25:C} {1,15:C} {2,15:C} ", name1, name2, name3);
        }
    }

    class Pay3
    {
        decimal name1 = 50.45m;
        decimal name2 = 765.00m;
        decimal name3 = 120.10m;

        public override string ToString()
        {
            return string.Format("{0,25:C} {1,15:C} {2,15:C} ", name1, name2, name3);
        }
    }

    class Pay4
    {
        decimal name1 = 35.05m;
        decimal name2 = 155.30m;
        decimal name3 = 414.90m;

        public override string ToString()
        {
            return string.Format("{0,25:C} {1,15:C} {2,15:C} ", name1, name2, name3);
        }

    }
    class Pay5
    {
        decimal name1 = 135.00m;
        decimal name2 = 73.00m;
        decimal name3 = 8.10m;

        public override string ToString()
        {
            return string.Format("{0,25:C} {1,15:C} {2,15:C} ", name1, name2, name3);
        }
    }
    class total
    {
        decimal name1 = 321.10m;
        decimal name2 = 3.70m;
        decimal name3 = 47.00m;

        public override string ToString()
        {
            return string.Format("{0,20:C} {1,15:C} {2,15:C} ", name1, name2, name3);
        }
    }
}