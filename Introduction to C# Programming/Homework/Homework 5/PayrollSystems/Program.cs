/*
 * Modify the payroll system to include an additional Employee derived class,
 * PieceWorker, that represents an employee whose pay is based on the number
 * of pieces of merchandise produced. Class PieceWorker should contain private
 * instance variables wage (to store the employee's wage per piece) and pieces
 * (to store the number of pieces produced).
 * 
 * Provide a concrete implementation of method Earnings in class PieceWorker
 * that calculates the employee's earnings by multiplying the number of pieces
 * produced by the wage per piece.
 * 
 * Create an array of Employee variables to store references to objects of each
 * concrete class in the new Employee hierarchy.
 * 
 * Display each Employee's string representation and earnings.
 */

using System;

namespace PayrollSystems
{
    class Program
    {
        static void Main()
        {
            // Create an array of employees
            Employee[] employees = {
                    new PieceWorker("John", "Smith", "111-11-1111", 14, 20),
                    new PieceWorker("Karen", "Price", "222-22-2222", 32, 60),
                    new PieceWorker("Sue", "Jones", "333-33-3333", 48, 65),
                    new PieceWorker("Bob", "Lewis", "444-44-4444", 24, 30),
                    new PieceWorker("Yan", "Zheng", "555-55-5555", 12, 60)
            };

            // Print the result
            foreach (Employee employee in employees)
            {
                Console.WriteLine("{0}\n", employee);
            }

            Console.ReadKey();
        }
    }
}