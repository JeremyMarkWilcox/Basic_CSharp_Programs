using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAssignment
{
    // Derived class Employee
    class Employee : Person
    {
        // Implementation of the abstract method
        public override void SayName()
        {
            Console.WriteLine($"Employee Name: {FirstName} {LastName}");
        }
    }
}
