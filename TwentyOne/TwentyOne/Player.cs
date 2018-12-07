using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public Player(string name, int beginningBalance) // constructor to take two parameters (mark #1 for main program Player init)
        {
            Hand = new List<Card>(); // initialize and assign List<Card> to Hand
            Balance = beginningBalance; // receive argument to assign it to the property 'Balance' of Player class)
            Name = name; // receive name argument to initialize Name to assign it to the property 'Name' of Player class)
        }

        public List<Card> Hand { get; set; } // property
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount) // Bet method
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size.");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        public static Game operator+ (Game game, Player player) // operator+ : operator overloading for object + object (e.g. game + player)
        {
            game.Players.Add(player);
            return game;
        }
        public static Game operator- (Game game, Player player) // Game: object type, game: parameter, Player: object type, player: parameter
        {
            game.Players.Remove(player); // game: instance, Players: list
            return game;
        }
    }
}
