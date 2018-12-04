using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(); // instantiate class Game / game: instance (object) / Inheritance example
            game.Dealer = "Jesse"; // game: instance, Dealer: method(property)
            game.Name = "TwentyOne";
            Deck deck = new Deck(); // instantiate class Deck / Deck: datatype, object, class / deck: instance for 'Shuffle' method
            deck.Shuffle(3); // deck: instance, Shuffle: method, 3: argument / access Shuffle in Deck class (class method)

            foreach (Card card in deck.Cards) // Card: datatype / foreach runs against a list, card exists only in this loop / list of deck.Cards
            {
                Console.WriteLine(card.Face + " of " + card.Suit); // card.Face & card.Suit from Deck.cs
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
