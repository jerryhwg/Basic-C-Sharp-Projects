using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceBasic1
{
    interface IQuittable
    {
        void Quit();
    }

    public class iQuit : IQuittable // Create an object of type IQuittable and call the Quit() method via the specific interface
    {
        public void Quit()
        {
            Console.WriteLine("I Quit");
        }
    }
}
