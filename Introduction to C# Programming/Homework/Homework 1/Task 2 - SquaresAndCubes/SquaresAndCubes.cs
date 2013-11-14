// Task 2: Write a program that calculates the squares and cubes of the numbers from 0 to 10
//         and displays the resulting values in table format.
//         All calculations should be done in terms of a variable.

using System;

class SquaresAndCubes
{
    static void Main()
    {
        Console.WriteLine("┌───────┬───────┬───────┐");
        Console.WriteLine("│Number\t│Square\t│Cube\t│");
        Console.WriteLine("├───────┼───────┼───────┤");

        for (int n = 0; n <= 10; n++)
        {
            double Square = Math.Pow(n, 2);     // calculates the squares
            double Cube = Math.Pow(n, 3);       // calculates the cubes

            // Pints the result
            Console.WriteLine("│" + n + "\t│" + Square + "\t│" + Cube + "\t│");
        }
        Console.WriteLine("└───────┴───────┴───────┘");
    }
}