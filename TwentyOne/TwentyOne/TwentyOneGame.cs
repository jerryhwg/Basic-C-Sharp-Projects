using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame: Game, IWalkAway // Game: base class inheritance example, IWalkAway: interface inheritance example
    {
        public TwentyOneDealer Dealer { get; set; } // property 'TwentyOneDealer Dealer' specific to TwentyOneGame / Q: *TwentyOneDealer*

        public override void Play() // method / an inheriting class must implement Game.play as Game.play (base) is defined in the *abstract* class 'Game' / to implement more customize, we add *override*
        {
            Dealer = new TwentyOneDealer(); // start for this method code / instantiate a new dealer for TwentyOne game
            foreach (Player player in Players) // Players is a property of Game class, Player: object type, player: instance (object)
            {
                player.Hand = new List<Card>(); // ensure Hand is empty () / instantiate
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>(); // initialize Dealer's hand, empty ()
            Dealer.Stay = false;
            Dealer.Deck = new Deck(); // initialize Dealer's deck (start a new deck = refresh the deck for every single round)
        }
        public override void ListPlayers() // override virtual method
        {
            Console.WriteLine("21 Players:"); // added to test the override
            base.ListPlayers();
        }
        public void WalkAway(Player player) // (forced to) implement a specified method in an interface (IWalkAway)
        {
            throw new NotImplementedException();
        }
    }
}
