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
            Employee[] employees = new Employee[5];

            SalariedEmployee salariedEmployee = new SalariedEmployee("John", "Smith", "111-11-1111");
            HourlyEmployee hourlyEmployee = new HourlyEmployee("Karen", "Price", "222-22-2222");
            CommissionEmployee commissionEmployee = new CommissionEmployee("Sue", "Jones", "333-33-3333");
            BasePlusCommissionEmployee basePlusCommissionEmployee = new BasePlusCommissionEmployee("Bob", "Lewis", "444-44-4444");
            PieceWorker pieceWorker = new PieceWorker("Arnold", "Petrov", "555-55-5555", 10, 60);

            employees[0] = salariedEmployee;
            employees[1] = hourlyEmployee;
            employees[2] = commissionEmployee;
            employees[3] = basePlusCommissionEmployee;
            employees[4] = pieceWorker;


            // Print the result
            foreach (Employee employee in employees)
            {
                Console.WriteLine("{0}\n", employee);
            }

            Console.ReadKey();
        }
    }
}