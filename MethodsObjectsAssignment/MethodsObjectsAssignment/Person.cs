using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsObjectsAssignment
{
    // Create a class called Person with properties FirstName and LastName
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Create a void method SayName() that writes the person's full name to the console
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
