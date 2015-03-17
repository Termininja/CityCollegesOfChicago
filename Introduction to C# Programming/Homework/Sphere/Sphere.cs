// Task 1. Write a complete C# application to prompt the user for radius
//         of a sphere, and call method SphereVolume to calculate and
//         display the volume of the sphere.
//
//         Use the following statement:
//         double volume = ( 4 / 3 ) * Math.PI * Math.Pow( radius, 3 )

using System;

class Sphere
{
    static void Main()
    {
        // Reads the radius of the sphere
        Console.Write("Please, enter the radius: r = ");
        double radius = double.Parse(Console.ReadLine());

        // Prints the result
        Console.WriteLine("Sphere volume is: {0:F2}", SphereVolume(radius));
    }

    // Calculates the sphere volume
    private static double SphereVolume(double r)
    {
        return (4 / 3) * Math.PI * Math.Pow(r, 3);
    }
}