##Homework 4
***(Due: 2nd Nov., 2013)***

**Task 01.** Write a console application that inserts `30` random letters into a `List<char>`. Perform the following queries on the List and display your results:
* Use LINQ to sort the List in ascending order.
* Use LINQ to sort the List in descending order.
* Display the List in ascending order with duplicates removed.

Hint: Strings can be indexed like arrays to access a character at a specific index.

**Task 02.** Create the class `SavingsAccount`. Use the static variable `annualInterestRate` to store the annual interest rate for all account holders. Each object of the class contains a private instance variable `savingsBalance`, indicating the amount the saver currently has on deposit.

Provide method `CalculateMonthlyInterest` to calculate the monthly interest by multiplying the `savingsBalance` by `annualInterestRate` divided by 12 - this interest should be added to `savingsBalance`.

Provide static method `ModifyInterestRate` to set the `annualInterestRate` to a new value.

Write an application to test class `SavingsAccount`. Create two `savingsAccount` objects, `saver1` and `saver2`, with balances of `$2000` and `$3000`, respectively. Set `annualInterestRate` to `4%`, then calculate the monthly interest and display the new balances for both savers. Then set the `annualInterestRate` to `5%`, calculate the next month’s interest and display the new balances for both savers.