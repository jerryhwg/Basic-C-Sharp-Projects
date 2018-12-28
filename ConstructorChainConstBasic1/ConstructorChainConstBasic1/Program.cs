using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainConstBasic1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string carName = "Speedy racing car"; // const is useful to keep a varilable name permanent

            Console.WriteLine("My car name is {0}.",carName); // string formatting

            //string racerName = "Max Rider";

            var newRacer = new Racer("Max Rider"); // using constructor chain, 100 is taken as int racerLevel is not specified 
            // var is useful when not sure which datatype, here var is used instead of Racer as datatype

            Console.WriteLine("My racer name is {0} and his level is {1}", newRacer.Name, newRacer.Level);
            Console.Read();
        }
    }
}
