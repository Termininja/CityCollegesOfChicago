/*
Write a complete C# application to prompt the user for the call method to calculate the volume:
double radius of a sphere, and SphereVolume to calculate and display the volume of the sphere.

Use the following statement:
double volume = ( 4.0 / 3.0 ) * Math.PI * Math.Pow( radius, 3 )
 */

using System;

class Test
{
    static void Main()
    {
        Console.Write("Please, enter the radius: r = ");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("Sphere volume is: {0:F2}", SphereVolume(radius));
    }

    private static double SphereVolume(double r)
    {
        return (4 / 3) * Math.PI * Math.Pow(r, 3);
    }
}