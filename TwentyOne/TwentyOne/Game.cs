using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game // abstract: never instantiate, never a instance (object) / base class
    {
        private List<Player> _players = new List<Player>(); // instantiate with empty list (without this, in other words with 'null', the program will error
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>(); // instantiate with empty

        public List<Player> Players { get { return _players; } set { _players = value; } } // property of Game (class, object, datatype) / per private, player is always empty value unless it's set with a value
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } // property 'Bets' and its datatype is Dictionary to represent who has how much amount of bet

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
