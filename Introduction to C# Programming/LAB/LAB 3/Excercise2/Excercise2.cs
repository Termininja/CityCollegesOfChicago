/*
(Sales Commissions)
Use a one-dimensional array to solve the following problem: A company pays its salespeople
on a commission basis. The salespeople receive $200 per week plus 9% of their gross sales
for that week. For example, a salesperson who grosses $5000 in sales in a week receives
$200 plus 9% of $5000, or a total of $650.

Write an application (using an array of counters) that determines how many of the salespeople
earned salaries in each of the following ranges (assume that each salesperson’s salary is
truncated to an integer amount):
a) $200–299
b) $300–399
c) $400–499
d) $500–599
e) $600–699
f) $700–799
g) $800–899
h) $900–999
i) $1000 and over
Summarize the results in tabular format.
 */

using System;

class Excercise2
{
    static void Main()
    {
        const decimal commissionPerWeek = 200;
        int[] salaries = new int[9];

        Console.Write("Please, enter the number of salespeople: ");
        int N = int.Parse(Console.ReadLine());
        for (int i = 1; i <= N; i++)
        {
            Console.Write("Enter the gross sale for salesperson {0}: ", i);
            decimal total = commissionPerWeek + decimal.Parse(Console.ReadLine()) * 0.09m;
            
            int result = (int)(total / 100) - 2;
            if (result > 8) result = 8;
            salaries[result]++;
        }

        PrintSalary(salaries);              // prints the result
    }

    private static void PrintSalary(int[] s)
    {
        for (int n = 2; n <= 9; n++)
        {
            Console.WriteLine("${0}00–{0}99:\t{1}", n, s[n - 2]);
        }
        Console.WriteLine("$1000 and over:\t" + s[8]);
    }
}