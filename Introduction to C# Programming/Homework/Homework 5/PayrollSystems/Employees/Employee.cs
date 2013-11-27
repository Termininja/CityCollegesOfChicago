using System;

namespace PayrollSystems
{
    public abstract class Employee
    {
        // Properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string SocialSecurityNumber { get; private set; }

        // Constructor
        public Employee(string firstName, string lastName, string socialSecurityNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SocialSecurityNumber = socialSecurityNumber;
        }

        // Methods
        public override string ToString()
        {
            return string.Format(
                "{0} {1}\nSocial security number: {2}\nEarnings: {3}",
                FirstName, LastName, SocialSecurityNumber, this.Earnings());
        }

        public abstract decimal Earnings();
    }
}
