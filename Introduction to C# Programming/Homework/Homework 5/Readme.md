##Homework 5
***(Due: 16th Nov., 2013)***

**Task 01.** Package-delivery services, such as FedEx®, DHL® and UPS®, offer a number of different shipping options, each with specific costs associated.

Create an inheritance hierarchy to represent various types of packages. Use `Package` as the base class of the hierarchy, then include classes `TwoDayPackage` and `OvernightPackage` that derive from `Package`. Base class `Package` should include the name, address, city, state and zip code for the package's sender and recipient, and instance variables that store the weight (in ounces) and cost per ounce to ship the package. Package's constructor should initialize these private instance variables with public properties. Ensure that the weight and cost per ounce contain positive values.

Package should provide a public method `CalculateCost` that returns a decimal indicating the cost associated with shipping the package. `Package`'s `CalculateCost` method should determine the cost by multiplying the weight by the cost per ounce.

Derived class `TwoDayPackage` should inherit the functionality of base class `Package`, but also include an instance variable that represents a flat fee the shipping company charges for two-day delivery service. `TwoDayPackage`'s constructor should receive a value to initialize this instance variable. `TwoDayPackage` should redefine method `CalculateCost` so that it computes the shipping cost by adding the flat fee to the weight-based cost calculated by base class `Package`'s `CalculateCost` method.

Class `OvernightPackage` should inherit directly from class `Package` and contain an instance variable representing an additional fee per ounce charged for overnight delivery service. `OvernightPackage` should redefine method `CalculateCost` so that it adds the additional fee per ounce to the standard cost per ounce before calculating the shipping cost.

Write a test application that creates objects of each type of `Package` and tests method `CalculateCost`.

**Task 02.** Modify the payroll system to include an additional Employee derived class `PieceWorker`, that represents an employee whose pay is based on the number of pieces of merchandise produced. Class `PieceWorker` should contain private instance variables wage (to store the employee's wage per piece) and pieces (to store the number of pieces produced).
 
Provide a concrete implementation of method `Earnings` in class `PieceWorker` that calculates the employee's earnings by multiplying the number of pieces produced by the wage per piece.
 
Create an array of Employee variables to store references to objects of each concrete class in the new Employee hierarchy.
 
Display each Employee's string representation and earnings.