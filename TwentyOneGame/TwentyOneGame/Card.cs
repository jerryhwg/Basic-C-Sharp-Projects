using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    public class Card
    {
        public Card() // constructor (same name as class)
        {
            Suit = "Spades";
            Face = "Two";
            // default value for Card
        }
        public string Suit { get; set; } // property "Suit", its datatype is 'string', get or set this property(Suit)
        public string Face { get; set; }
    }
}
