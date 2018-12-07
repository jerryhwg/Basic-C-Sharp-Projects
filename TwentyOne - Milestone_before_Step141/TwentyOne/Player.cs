using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; } // property
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

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
