using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee // inheritance
    {
        public static bool operator ==(Employee x, Employee y)
        {
            return Equals(x, y);
        }

        public static bool operator !=(Employee x, Employee y)
        {
            return !Equals(x, y);
        }

        public int Id { get; set; } // property of Employee object(class, object type)
    }
}
