using System;

public abstract class Employee
{
    public Employee(string firstName, string lastName, string socialSecurityNumber)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.SocialSecurityNumber = socialSecurityNumber;
    }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string SocialSecurityNumber { get; private set; }

    public override string ToString()
    {
        var result = string.Format(
            "{0} {1}\nSocial security number: {2}\nEarnings: ${3}",
            FirstName, LastName, SocialSecurityNumber, this.Earnings());

        return result;
    }

    public abstract decimal Earnings();
}