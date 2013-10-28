using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int q = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int z = int.Parse(Console.ReadLine());

        Console.WriteLine("Sum: {0}\nDiffernce: {1}\nMuplication: {2}\nDivision: {3}", q + z, q - z, q * z, q / z);
    }
}