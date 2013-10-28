##Homework 3
***(Due: 19th Oct., 2013)***



LAB 3

Task 1
Write a complete C# application to prompt the user for the call method to calculate the volume:
double radius of a sphere, and SphereVolume to calculate and display the volume of the sphere.

Use the following statement:
double volume = ( 4.0 / 3.0 ) * Math.PI * Math.Pow( radius, 3 )

Task 2
(Sales Commissions)
Use a one-dimensional array to solve the following problem:  A company pays its salespeople on a commission basis. The salespeople receive $200 per week plus 9% of their gross sales for that week. For example, a salesperson who grosses $5000 in sales in a week receives $200 plus 9% of $5000, or a total of $650.
Write an application (using an array of counters) that determines how many of the salespeople earned salaries in each of the following ranges (assume that each salesperson’s salary is truncated to an integer amount):
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











**Task 01.** A parking garage charges a `$2.00` minimum fee to park for up to three hours. The garage charges an additional `$0.50` per hour for each hour or part thereof in excess of three hours. The maximum charge for any given 24-hour period is `$10.00`. Assume that no car parks for longer than 24 hours at a time.

Write an application that calculates and displays the parking charges for each customer who parked in the garage yesterday. You should enter the hours parked for each customer. The application should display the charge for the current customer and should calculate and display the running total of yesterday’s receipts. The application should use method `CalculateCharges` to determine the charge for each customer.

**Task 02.** Use a rectangular array to solve the following problem:

A company has three salespeople (1 to 3) who sell five different products (1 to 5). Once a day, each salesperson passes in a slip for each type of product sold. Each slip contains the following:
* The salesperson number
* The product number
* The total dollar value of that product sold that day

Thus, each salesperson passes in between `0` and `5` sales slips per day. Assume that the information from all of the slips for last month is available.

Write an application that will read all the information for last month’s sales and summarize the total sales by salesperson and by product. All totals should be stored in rectangular array sales. After processing all the information for last month, display the results in tabular format, with each column representing a particular salesperson and each row repressenting a particular product.

Cross-total each row to get the total sales of each product for last month. Cross-total each column to get the total sales by salesperson for last month. Your tabular output should include these cross-totals to the right of the totaled rows and below the totaled columns.
