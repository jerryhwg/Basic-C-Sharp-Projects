using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChainConstBasic1
{
    public class Racer
    {
        public Racer(string name) : this (name, 100) // constructor chain
        {
        }
        public Racer(string name, int racerLevel) // initial constructor for Racer
        {
            Name = name; // instructions defined in constructor
            Level = racerLevel;
        }
        public int Level { get; set; } // property type of Racer class(object)
        public string Name { get; set; }
    }
}
