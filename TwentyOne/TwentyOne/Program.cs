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
                Player player = new Player(playerName, bank); // instantiate == create a new 'player' (based on Player class) = initialize him (also have a player *constructor* in Player.cs - see mark #1)
                // value (playerName) for name parameter for Name property, value (bank) for beginningBalance parameter for property Balance
                Game game = new TwentyOneGame(); // also instantiate a game / polymorphism applies here to expose overloaded operator
                game += player; // we're adding player to the game via overloaded operator + (combine two objects together by the Game class)
                player.isActivelyPlaying = true; // isActivelyPlaying = a property of player / will be used for while loop (while player is actively playing)
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play(); // play method in Game class
                }
                game -= player; // happens after while loop exit
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now"); // no if case
            Console.Read(); // pause
        }
    }
}
