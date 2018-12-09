using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; } // Dealer has Deck (so included as a property instead of inheritance that is for is relationship)
        public int Balance { get; set; }

        public void Deal(List<Card> Hand) // method 'Deal'
        {
            Hand.Add(Deck.Cards.First()); // First: method to take the very first item in the list, then add it to the Hand (pass into Deal)
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); // Show which card
            Deck.Cards.RemoveAt(0); // 0 index = first Card from Deck.Cards list
        }
    }
}
