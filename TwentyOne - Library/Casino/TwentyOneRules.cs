using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneRules
    {
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() // reason for 'static' method: we don't have objects to access this, but just a bunch of methods we call from other classes / just basic helper method isolated to be called from out of this class
        // private dictionary (private class name start with underscore) - only gonna be accessed within this class / private is good to prevent the name conflict in other classes
        // <Face, int> Face: key, int for value e.g. jack = 10
        {
            [Face.Two] = 2, // instatiate dictionary entries / dictionaly contains key to be looked up its value
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10, // for dupliclate value, enum is not a proper type to use, so we use dictionary instead
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); // lambda expression
            int[] result = new int[aceCount + 1]; // array
            int value = Hand.Sum(x => _cardValues[x.Face]); // use the private method in this class '_cardValues[x.Face]' / look ath the x.Face value and assign its sum to value (int)
            result[0] = value; // take the very first entry in the integer array and assign the value to it
            if (result.Length == 1) return result;
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10); // = value = value + (i * 10); / for Ace card
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand) // reason for 'static' method: we don't have objects to access this, but just a bunch of methods we call from other classes (kind of business logic)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand); // use another method 'GetAllPossibleHandValues(Hand)' which also uses '_cardValues[x.Face]' private class
            int value = possibleValues.Max(); // lambda function / get the max value
            if (value == 21) return true; // if the max value = 21, then blackjack / static method to return bool value 'true' or 'false'
            else return false; // return false means no blackjack

        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min(); // lambda expression
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max(); // *** lambda expression that gives me a result where player's score less than 22 (buested threshold) and highest value (max) to compare the result (x) with a dealer's highest score
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null; // bool? makes it possible to have the return 'null'
        }
    }
}
