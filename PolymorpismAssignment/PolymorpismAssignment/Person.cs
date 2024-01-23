using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorpismAssignment
{
    // Abstract class Person
    abstract class Person
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method
        public abstract void SayName();
    }
}