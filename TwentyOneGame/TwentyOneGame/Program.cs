using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); // instantiate, deck: instance for 'Shuffle' method, return from 'Shuffle' method
            deck.Shuffle(3); // deck: instance, Shuffle: method, 3: given parameter, access Shuffle in Deck class (class method)

            foreach (Card card in deck.Cards) // Card: datatype, foreach runs against a list, card exists in this loop, list of deck.Cards, deck.Cards: deck instance, Q: why Cards in deck.Cards?
            {
                Console.WriteLine(card.Face + " of " + card.Suit); // card.Face & card.Suit from Deck.cs
            }
            Console.WriteLine(deck.Cards.Count); // count: property(?)
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
