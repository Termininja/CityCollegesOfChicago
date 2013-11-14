﻿/* Task 2. Use a rectangular array to solve the following problem: A company has three salespeople
 *         (1 to 3) who sell five different products (1 to 5). Once a day, each salesperson passes
 *         in a slip for each type of product sold. Each slip contains the following:
 *            a)	The salesperson number
 *            b)	The product number
 *            c)	The total dollar value of that product sold that day
 *            
 *         Thus, each salesperson passes in between 0 and 5 sales slips per day. Assume that the
 *         information from all of the slips for last month is available.
 *         
 *         Write an application that will read all the information for last month’s sales and
 *         summarize the total sales by salesperson and by product. All totals should be stored in
 *         rectangular array sales.
 *         
 *         After processing all the information for last month, display the results in tabular
 *         format, with each column representing a particular salesperson and each row repressenting
 *         a particular product.
 *         
 *         Cross-total each row to get the total sales of each product for last month. Cross-total
 *         each column to get the total sales by salesperson for last month. Your tabular output should
 *         include these cross-totals to the right of the totaled rows and below the totaled columns.
 */

using System;

namespace SalesReport
{
    class Program
    {
        static void Main()
        {
            Salesperson[] employees = { new Salesperson("Salesperson 1") };
            foreach (var element in employees) Console.WriteLine(element);

            Pay1[] pay = { new Pay1() };
            foreach (var element in pay) Console.WriteLine(element);

            Pay2[] pay2 = { new Pay2() };
            foreach (var element in pay2) Console.WriteLine(element);

            Pay3[] pay3 = { new Pay3() };
            foreach (var element in pay3) Console.WriteLine(element);

            Pay4[] pay4 = { new Pay4() };
            foreach (var element in pay4) Console.WriteLine(element);

            Pay5[] pay5 = { new Pay5() };
            foreach (var element in pay5) Console.WriteLine(element);

            Console.Write(new string('─', 58) + "\nTotal");
            total[] to = { new total() };
            foreach (var element in to) Console.WriteLine(element);

            Console.ReadKey();
        }
    }
}