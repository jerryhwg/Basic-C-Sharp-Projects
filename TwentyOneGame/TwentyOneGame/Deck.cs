using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Deck // Deck class is a receipe
    {
        public Deck() // constructor first (same name as class), Deck: object (?) 
        {
            Cards = new List<Card>(); // instantiate
            List<string> Suits = new List<string>() { "Club", "Hearts", "Diamonds", "Spades" }; // list of Suits
            List<string> Faces = new List<string>() // list of Faces
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces) // foreach runs for list
            {
                foreach (string suit in Suits) // double loop to list all cases of Cards
                {
                    Card card = new Card(); // card: instance (variable), Card: class, (): constructor, card variable only exists in the loop
                    card.Suit = suit; // assign, take a card (suit) from list via loop
                    card.Face = face; // assign
                    Cards.Add(card); // add each new card to Cards list
                }
            }

        }
        public List<Card> Cards { get; set; } // "Cards": property, and its datatype is list, get or set this property(Cards) = add to property

        public void Shuffle(int times = 1) // Shuffle: method, times = 1: optional (old: Deck: datatype, deck: instance (variable? object?))
            //(old comments) static: you can call this method 'Shuffle' withouth applying(having) this specific deck that I created (if I remove 'static', then the method belongs to 'Deck' object
            //void: no return needed, internally works
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]); // build 'TempList'
                    Cards.RemoveAt(randomIndex); // remove card from Cards
                }
                Cards = TempList; // 'TempList' becomes Cards
            }
        }
    }
}
