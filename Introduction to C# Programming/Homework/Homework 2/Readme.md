##Homework 2
***(Due: 5th Oct., 2013)***

**Task 01.** Create a class called `Invoice` that a hardware store might use to represent an invoice for an item sold at the store. An Invoice should include four pieces of information as either instance variables or automatic properties—a part number (type `string`), a part description (type `string`), a quantity of the item being purchased (type `int`) and a price per item (type `decimal`).

Your class should have a constructor that initializes the four values. Provide a property with a get and set accessor for any instance variables. For the `Quantity` and `PricePerItem` properties, if the value passed to the set accessor is negative, the value of the instance variable should be left unchanged. Also, provide a method named `GetInvoiceAmount` that calculates the invoice amount (i.e., multiplies the quantity by the price per item), then returns the amount as a `decimal` value.

Write a test application named `InvoiceTest` that demonstrates class Invoice’s capabilities.

**Task 02.** A website sells three products whose retail prices are as follows:
  * Product 1, `$2.98`
  * Product 2, `$4.50`
  * Product 3, `$9.98`

Write an application that reads a series of pairs of numbers as follows:
  * product number
  * quantity sold

Your application should use a switch statement to determine the retail price for each product. It should calculate and display the total retail value of all products sold. Use a sentinel-controlled loop to determine when the application should stop looping and display the final results.