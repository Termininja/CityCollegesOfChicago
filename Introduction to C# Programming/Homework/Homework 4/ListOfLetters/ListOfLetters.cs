// Task 1. Write a console application that inserts 30 random letters into a List<char>.
//         Perform the following queries on the List and display your results:
//            a. Use LINQ to sort the List in ascending order.
//            b. Use LINQ to sort the List in descending order.
//            c. Display the List in ascending order with duplicates removed.
//         Hint: Strings can be indexed like arrays to access a character at a specific index.

using System;
using System.Collections.Generic;
using System.Linq;

class ListOfLetters
{
    static void Main()
    {
        // Create one list of letters by random generator
        Random generator = new Random();
        List<char> randomList = new List<char>();
        for (int i = 0; i <= 30; i++) randomList.Add((char)generator.Next(97, 123));
        PrintList("Random generated list of letters:", randomList);

        // Sort the list in ascending order
        var ascendingList = from letter in randomList orderby letter ascending select letter;
        PrintList("\nSorted list in ascending order:", ascendingList);

        // Sort the list in descending order
        var descendingList = from letter in randomList orderby letter descending select letter;
        PrintList("\nSorted list in descending order:", descendingList);

        // Display the list in ascending order with duplicates removed
        var duplicatesRemoved = ascendingList.Distinct();
        PrintList("\nSorted list in ascending order with duplicates removed:", duplicatesRemoved);
    }

    // Print some list of chars
    private static void PrintList(string text, dynamic list)
    {
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.White;
        foreach (var letter in list) Console.Write(letter + " ");
        Console.ResetColor();
        Console.WriteLine();
    }
}