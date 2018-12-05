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
            return Equals(x.Id, y.Id); // .Id for employee id property
        }

        public static bool operator !=(Employee x, Employee y)
        {
            return !Equals(x.Id, y.Id);
        }

        public int Id { get; set; } // property 'employee id' of Employee object(class, object type)
        //public string FName { get; set; }
        //public string LName { get; set; }
    }
}
