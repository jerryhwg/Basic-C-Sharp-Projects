using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game // abstract: never instantiate, never a instance (object) / base class
    {
        public List<Player> Players { get; set; } // property of Game (class, object, datatype)
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get; set; } // property 'Bets' and its datatype is Dictionary to represent who has how much amount of bet

        public abstract void Play(); // abstract method - contains no implementation / abstract method only in abstract class / all derived (inheriting) class must implement this method

        public virtual void ListPlayers() // virtual method inside an abstract class / virtual method has an implementation and gets inherited by derived classes but can be overriden using override method
            // virtual (implementation: yes) - overriden by override method
            // abstract (implementation: no) - overriden by override method
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
