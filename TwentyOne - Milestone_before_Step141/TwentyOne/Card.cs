using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        public Suit Suit { get; set; } // property "Suit", its datatype is 'string', get or set this property(Suit)
        public Face Face { get; set; } // 1st Face enum type, 2nd Face property
    }
    public enum Suit // enum for Suit, limited values (4)
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face // enum for Face, limited values (13)
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
