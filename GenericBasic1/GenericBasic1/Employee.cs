using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericBasic1
{
    public class Employee<T> // make Employee class to take a generic type parameter
    {
        public List<T>Things { get; set; } // property 'Things' of Employee with generic list, <T> matching the generic type of the class either <string> or <int> or whatever
    }
}
