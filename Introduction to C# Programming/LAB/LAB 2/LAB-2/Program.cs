//determine the average mileage for gallon per tank of gas
using System;
class AverageMile
{
    public static void Main()
    {
        int totalTankfuls = 0;
        int inputMileage;
        int totalMileage = 0; // sum of miles driven
        int totalGallons = 0; // sum gallons used

        Console.WriteLine("Enter mileage or -1 to quit: ");
        while (!int.TryParse(Console.ReadLine(), out inputMileage)) ;

        while (inputMileage != -1)
        {
            totalTankfuls++;

            if (inputMileage > 0)
            {
                totalMileage += inputMileage;
            }

            Console.WriteLine("Enter gallons used: ");
            int inputGallons;
            while (!int.TryParse(Console.ReadLine(), out inputGallons)) ;

            if (inputGallons > 0)
            {
                totalGallons += inputGallons;
            }
            Console.WriteLine("Enter mileage or -1 to quit: ");
            while (!int.TryParse(Console.ReadLine(), out inputMileage)) ;
        }

        if (totalTankfuls > 0)
        {
            Console.WriteLine("Total of {0} miles driven on {1} tanks of fuel; average is {2} miles per tankful", totalMileage, totalTankfuls, (double)totalMileage / totalTankfuls);
            Console.WriteLine("Average mile per gallon across all tankfuls is: {0}", (double)totalMileage / totalGallons);
        }
        else Console.WriteLine("No mileage entered");
    }
}