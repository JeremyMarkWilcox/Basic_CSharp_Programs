using System;
using System.Collections.Generic;
using System.Text;

namespace ParametersGenericAssignment
{
    // The T is the placeholder for the generic type parameter
    class Employee<T>
    {
        // Property "Things" with a generic list matching the generic type of the class
        public List<T> Things { get; set; } = new List<T>();
    }
}
