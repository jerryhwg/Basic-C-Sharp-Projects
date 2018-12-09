using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck // Deck class is a receipe
    {
        public Deck() // Constructor first (same name as class) / Deck: method name / constructor = a special method of the same name class / it gets automatically invoked whenever an instance of the class is created / it also contains the collection of instructions
        // constructor is used to assign initial values to the data members of the same class
        {
            Cards = new List<Card>(); // instantiate for a new list (object initializer), this happens with 'Deck deck = new Deck();' to create a fully populate deck

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card(); // instantiate
                    card.Face = (Face)i; // card.Face: Face = card property / (Face): enum type after Card enum type Face declare / choose iTh value from the Face(enum) list and assign it to the card's Face property
                    card.Suit = (Suit)j; // explicit casting an int (underlying value of enum) into an enum
                    Cards.Add(card); // 52 cards for List<Card>
                }
            }
        }
        public List<Card> Cards { get; set; } // "Cards": property, List<Card> type / get or set this property(Cards) = add to property

        public void Shuffle(int times = 1) // Shuffle: method, times = 1: optional
                                           // (old comments) static: you can call this method 'Shuffle' withouth applying(having) this specific deck that I created (if I remove 'static', then the method belongs to 'Deck' object
                                           // void: no return needed, internally just works
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
