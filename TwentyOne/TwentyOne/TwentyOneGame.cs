using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame: Game // Inheritance example
    {
        public override void Play() // an inheriting class must implement Game.play for abstract class/method in Game class / to implement, add override
        {
            throw new NotImplementedException();
        }
        public override void ListPlayers() // override virtual method
        {
            Console.WriteLine("21 Players:"); // added to test the override
            base.ListPlayers();
        }
    }
}
