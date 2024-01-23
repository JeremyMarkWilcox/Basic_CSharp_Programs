using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorpismAssignment
{
    // Employee class inheriting from IQuittable interface
    class Employee : Person, IQuittable
    {
        // Implement the Quit() method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine("Employee is quitting...");
        }

        public override void SayName()
        {
            Console.WriteLine($"Employee Name: {FirstName} {LastName}");
        }
    }
}
