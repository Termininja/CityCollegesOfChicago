using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter frist number:  ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("Enter thrid number:  ");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("The product is: {0}", x * y * q);
    }
}