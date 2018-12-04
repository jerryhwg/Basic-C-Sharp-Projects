using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassBasic1
{
    interface IQuittable
    {
        void Quit();
    }

    public class iQuit : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I Quit");
        }
    }
}
