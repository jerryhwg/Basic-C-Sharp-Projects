using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName); // string formatting
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank); // instantiate with two arguments as defined in constructor in Player class ==> create a new 'player' (mark #1)
                                                              // value (playerName) for name parameter for Name property, value (bank) for beginningBalance parameter for property Balance

                Game game = new TwentyOneGame(); // instantiate a game / polymorphism applies here / Game = base, detailed implementation uses TwentyOneGame as this game is TwentyOneGame
                game += player; // (game = game + player) we're adding player to the game via overloaded operator + (combine two objects together with operator overload) as defined in Player class
                player.isActivelyPlaying = true; // isActivelyPlaying = a property of player / will be used for while loop (while player is actively playing)

                while (player.isActivelyPlaying && player.Balance > 0) // *** (while true =) as long as the player's isActivelyPlaying value is true (answer 'yes' for play? question) AND player's balance is not empty amount, game on (run 'play' method in Game class)! 
                {
                    game.Play(); // play method in Game class / game = new game (instance)
                }

                game -= player; // happens after while loop exit
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the casino. Bye for now"); // case if NO answered
            Console.Read(); // pause
        }
    }
}
