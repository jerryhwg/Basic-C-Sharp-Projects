using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception // inherit (Exception handles ArgumentException as well, for example) - another example of polymorphism
    {
        public FraudException() // a standard constructor
            : base() { } // inherit from base constructor (Exception)
        public FraudException(string message) // overload the above one to take one argument
            : base(message) { }
        // two methods here, both are constructor that will inherit from Exception
        // here this separate class 'FraudException' is for the specific exception, but still uses method from Exception (inheriticance) for other exception cases
    }
}
