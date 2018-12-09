using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card); // Show which card
            using (StreamWriter file = new StreamWriter(@"C:\Users\jerry\Logs\log.txt", true)) // true = append (if you put mouse over 'StreamWriter', you will see 'bool append' in the place
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card); // once hits this statement, the above streamwriter is flushed from memory
            }
            Deck.Cards.RemoveAt(0); // 0 index = first Card from Deck.Cards list
        }
    }
}
