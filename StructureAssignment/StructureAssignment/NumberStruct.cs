using System;
using System.Collections.Generic;
using System.Text;

namespace StructureAssignment
{
    // Define the struct Number
    struct Number
    {
        public decimal Amount { get; set; }

        // Constructor to initialize the Amount property
        public Number(decimal amount)
        {
            // I tried to set it without parameters the first time and
            // from what I read it can't because a Struct is a value type, interesting!
            Amount = amount;
        }
    }
}
