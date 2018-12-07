using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneDealer : Dealer // this dealer is specific to TwentyOne Game and it inherit from 'Dealer' class
    {
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } } // property type / Q: *List<Card>*
        public bool Stay { get; set; }
        public bool isBusted { get; set; }
    }
}
