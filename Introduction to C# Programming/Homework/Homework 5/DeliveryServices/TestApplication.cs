/*
 * Package-delivery services, such as FedEx®, DHL® and UPS®, offer a number of different shipping
 * options, each with specific costs associated.
 * 
 * Create an inheritance hierarchy to represent various types of packages. Use Package as the base
 * class of the hierarchy, then include classes TwoDayPackage and OvernightPackage that derive from
 * Package. Base class Package should include the name, address, city, state and zip code for the
 * package's sender and recipient, and instance variables that store the weight (in ounces) and cost
 * per ounce to ship the package. Package's constructor should initialize these private instance
 * variables with public properties. Ensure that the weight and cost per ounce contain positive values.
 * 
 * Package should provide a public method CalculateCost that returns a decimal indicating the cost
 * associated with shipping the package. Package's CalculateCost method should determine the cost by
 * multiplying the weight by the cost per ounce.
 * 
 * Derived class TwoDayPackage should inherit the functionality of base class Package, but also
 * include an instance variable that represents a flat fee the shipping company charges for two-day
 * delivery service. TwoDayPackage's constructor should receive a value to initialize this instance
 * variable. TwoDayPackage should redefine method CalculateCost so that it computes the shipping
 * cost by adding the flat fee to the weight-based cost calculated by base class Package's
 * CalculateCost method.
 * 
 * Class OvernightPackage should inherit directly from class Package and contain an instance variable
 * representing an additional fee per ounce charged for overnight delivery service. OvernightPackage
 * should redefine method CalculateCost so that it adds the additional fee per ounce to the standard
 * cost per ounce before calculating the shipping cost.
 * 
 * Write a test application that creates objects of each type of Package and tests method CalculateCost.
 */

using System;

namespace DeliveryServices
{
    class TestApplication
    {
        static void Main()
        {
            try
            {
                // Creates objects of each type of Package
                Package normalPackage = new Package("package1", "11 W Mainstreet", "Chicago", "IL", 606000, 500, 1);
                TwoDayPackage twoDayPackage = new TwoDayPackage("package2", "21 E Shisharka", "New York", "NY", 546000, 500, 1, 5);
                OvernightPackage overnightPackage = new OvernightPackage("package3", "37 N Lemon", "Los Angelis", "CA", 345000, 500, 1, 10);

                // Tests the method CalculateCost
                Console.WriteLine("Normal Package: $ " + normalPackage.CalculateCost());
                Console.WriteLine("TwoDay Package: $ " + twoDayPackage.CalculateCost());
                Console.WriteLine("Overnight Package: $ " + overnightPackage.CalculateCost());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}