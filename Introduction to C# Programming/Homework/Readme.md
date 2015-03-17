##Part 1 (Due: 21st Sept., 2013)

**Task 01.** Write a program that inputs three integer from the user and displays the sum, average, product, and smallest and largest of the numbers.

**Task 02.** Write a program that calculates the squares and cubes of the numbers from `0` to `10` and displays the resulting values in table format. All calculations should be done in terms of a variable.

**Task 03.** Write a program `Ticket.cs` that will allow the user to enter actual speed limit, the speed limit at which the offender was travelling, and the number of previous tickets that person has received. The application should calculate and display how many miles over the speed limit the offender was travelling, the cost of the speeding ticket, and court cost. Use `$10.00` as the amount to be charged for each mile per hour over the speed limit. The court cost should begin at `$50.00` and increase by `$20.00` for each subsequent offence up to the third offence (that will represent the maximum court cost).

##Part 2 (Due: 5th Oct., 2013)

**Task 04.** Create a class called `Invoice` that a hardware store might use to represent an invoice for an item sold at the store. An Invoice should include four pieces of information as either instance variables or automatic properties—a part number (type `string`), a part description (type `string`), a quantity of the item being purchased (type `int`) and a price per item (type `decimal`).

Your class should have a constructor that initializes the four values. Provide a property with a get and set accessor for any instance variables. For the `Quantity` and `PricePerItem` properties, if the value passed to the set accessor is negative, the value of the instance variable should be left unchanged. Also, provide a method named `GetInvoiceAmount` that calculates the invoice amount (i.e., multiplies the quantity by the price per item), then returns the amount as a `decimal` value.

Write a test application named `InvoiceTest` that demonstrates class Invoice’s capabilities.

**Task 05.** A website sells three products whose retail prices are as follows:
  * Product 1, `$2.98`
  * Product 2, `$4.50`
  * Product 3, `$9.98`

Write an application that reads a series of pairs of numbers as follows:
  * product number
  * quantity sold

Your application should use a switch statement to determine the retail price for each product. It should calculate and display the total retail value of all products sold. Use a sentinel-controlled loop to determine when the application should stop looping and display the final results.

##Part 3 (Due: 19th Oct., 2013)

**Task 06.** Write a complete C# application to prompt the user for `radius` of a sphere, and call method `SphereVolume` to calculate and display the volume of the sphere.

Use the following statement: `double volume = ( 4 / 3 ) * Math.PI * Math.Pow( radius, 3 )`

**Task 07.** Use a one-dimensional array to solve the following problem: A company pays its salespeople on a commission basis. The salespeople receive `$200` per week plus `9%` of their gross sales for that week.
>Example: A salesperson who grosses `$5000` in sales in a week receives `$200` plus `9%` of `$5000`, or a total of `$650`.

Write an application (using an array of counters) that determines how many of the salespeople earned salaries in each of the following ranges (assume that each salesperson’s salary is truncated to an integer amount):
* `$200` – `$299`
* `$300` – `$399`
* `$400` – `$499`
* `$500` – `$599`
* `$600` – `$699`
* `$700` – `$799`
* `$800` – `$899`
* `$900` – `$999`
* `$1000` and over

Summarize the results in tabular format.

**Task 08.** A parking garage charges a `$2.00` minimum fee to park for up to three hours. The garage charges an additional `$0.50` per hour for each hour or part thereof in excess of three hours. The maximum charge for any given 24-hour period is `$10.00`. Assume that no car parks for longer than 24 hours at a time.

Write an application that calculates and displays the parking charges for each customer who parked in the garage yesterday. You should enter the hours parked for each customer. The application should display the charge for the current customer and should calculate and display the running total of yesterday’s receipts. The application should use method `CalculateCharges` to determine the charge for each customer.

**Task 09.** Use a rectangular array to solve the following problem:

A company has three salespeople (1 to 3) who sell five different products (1 to 5). Once a day, each salesperson passes in a slip for each type of product sold. Each slip contains the following:
* The salesperson number
* The product number
* The total dollar value of that product sold that day

Thus, each salesperson passes in between `0` and `5` sales slips per day. Assume that the information from all of the slips for last month is available.

Write an application that will read all the information for last month’s sales and summarize the total sales by salesperson and by product. All totals should be stored in rectangular array sales. After processing all the information for last month, display the results in tabular format, with each column representing a particular salesperson and each row representing a particular product.

Cross-total each row to get the total sales of each product for last month. Cross-total each column to get the total sales by salesperson for last month. Your tabular output should include these cross-totals to the right of the totalled rows and below the totalled columns.

##Part 4 (Due: 2nd Nov., 2013)

**Task 10.** Write a console application that inserts `30` random letters into a `List<char>`. Perform the following queries on the List and display your results:
* Use LINQ to sort the List in ascending order.
* Use LINQ to sort the List in descending order.
* Display the List in ascending order with duplicates removed.

Hint: Strings can be indexed like arrays to access a character at a specific index.

**Task 11.** Create the class `SavingsAccount`. Use the static variable `annualInterestRate` to store the annual interest rate for all account holders. Each object of the class contains a private instance variable `savingsBalance`, indicating the amount the saver currently has on deposit.

Provide method `CalculateMonthlyInterest` to calculate the monthly interest by multiplying the `savingsBalance` by `annualInterestRate` divided by 12 - this interest should be added to `savingsBalance`.

Provide static method `ModifyInterestRate` to set the `annualInterestRate` to a new value.

Write an application to test class `SavingsAccount`. Create two `savingsAccount` objects, `saver1` and `saver2`, with balances of `$2000` and `$3000`, respectively. Set `annualInterestRate` to `4%`, then calculate the monthly interest and display the new balances for both savers. Then set the `annualInterestRate` to `5%`, calculate the next month’s interest and display the new balances for both savers.

##Part 5 (Due: 16th Nov., 2013)

**Task 12.** Package-delivery services, such as FedEx®, DHL® and UPS®, offer a number of different shipping options, each with specific costs associated.

Create an inheritance hierarchy to represent various types of packages. Use `Package` as the base class of the hierarchy, then include classes `TwoDayPackage` and `OvernightPackage` that derive from `Package`. Base class `Package` should include the name, address, city, state and zip code for the package's sender and recipient, and instance variables that store the weight (in ounces) and cost per ounce to ship the package. Package's constructor should initialize these private instance variables with public properties. Ensure that the weight and cost per ounce contain positive values.

Package should provide a public method `CalculateCost` that returns a decimal indicating the cost associated with shipping the package. `Package`'s `CalculateCost` method should determine the cost by multiplying the weight by the cost per ounce.

Derived class `TwoDayPackage` should inherit the functionality of base class `Package`, but also include an instance variable that represents a flat fee the shipping company charges for two-day delivery service. `TwoDayPackage`'s constructor should receive a value to initialize this instance variable. `TwoDayPackage` should redefine method `CalculateCost` so that it computes the shipping cost by adding the flat fee to the weight-based cost calculated by base class `Package`'s `CalculateCost` method.

Class `OvernightPackage` should inherit directly from class `Package` and contain an instance variable representing an additional fee per ounce charged for overnight delivery service. `OvernightPackage` should redefine method `CalculateCost` so that it adds the additional fee per ounce to the standard cost per ounce before calculating the shipping cost.

Write a test application that creates objects of each type of `Package` and tests method `CalculateCost`.

**Task 13.** Modify the payroll system to include an additional Employee derived class `PieceWorker`, that represents an employee whose pay is based on the number of pieces of merchandise produced. Class `PieceWorker` should contain private instance variables wage (to store the employee's wage per piece) and pieces (to store the number of pieces produced).
 
Provide a concrete implementation of method `Earnings` in class `PieceWorker` that calculates the employee's earnings by multiplying the number of pieces produced by the wage per piece.
 
Create an array of Employee variables to store references to objects of each concrete class in the new Employee hierarchy.
 
Display each Employee's string representation and earnings.