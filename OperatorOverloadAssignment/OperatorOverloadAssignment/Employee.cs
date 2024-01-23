using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloadAssignment
{
    class Employee
    {
        public int Id { get; set; }

        

        // Overloading the == operator
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Check if both objects are null 
            return ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null) ||
                   //This checks if their Id properties are equal
                   !ReferenceEquals(employee1, null) && !ReferenceEquals(employee2, null) && employee1.Id == employee2.Id;
        }

        // Overloading the != operator by using the negation of the == operator
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }
}
