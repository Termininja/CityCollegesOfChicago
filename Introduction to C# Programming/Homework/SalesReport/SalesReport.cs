/* Task 2. Use a rectangular array to solve the following problem: A company has three salespeople
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

class SalesReport
{
    static void Main()
    {
        var salesperson1 = new Salesperson("Salesperson 1");
        var salesperson2 = new Salesperson("Salesperson 2");
        var salesperson3 = new Salesperson("Salesperson 3");

        salesperson1.AddProducts(new Product[] { 
            new Product1(), new Product1(), new Product1(), 
            new Product2(),
            new Product3(), new Product3(),
            new Product4() 
        });

        salesperson2.AddProducts(new Product[] { 
            new Product1(), new Product1(), 
            new Product2(), new Product2(), new Product2(), new Product2(),
            new Product3(), new Product3(),
            new Product4(),
            new Product5(), new Product5(), new Product5()
        });

        salesperson3.AddProducts(new Product[] { 
            new Product1(), new Product1(), 
            new Product4(), new Product4(), new Product4(),
            new Product5()
        });

        Console.WriteLine(salesperson1);
        Console.WriteLine(salesperson2);
        Console.WriteLine(salesperson3);
    }
}