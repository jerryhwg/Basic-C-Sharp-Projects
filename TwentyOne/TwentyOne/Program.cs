using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text.";
            // File.WriteAllText(@"C:\Users\jerry\Logs\log.txt", text); // @ allows to replace \\ by \ for path specification
            //string text = File.ReadAllText(@"C:\Users\jerry\Logs\log.txt");

            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;

            //Player newPlayer = new Player("Jesse"); // utilize the contructor call chain (in Player.cs)

            const string casinoName = "Grand Hotel and Casino"; // constant is useful if you don't want to worry if the name is gonna change later
            Console.WriteLine("Welcome to {0}. Let's start by telling me your name.", casinoName); // casinoName is const
            string playerName = Console.ReadLine();

            bool validAnswer = false; // advanced exception handling code segment
            int bank = 0;
            while (!validAnswer) // continue to loop as long as invalid answer
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank); // Console.ReadLine(): in, bank: out -> assign back to a bank value right before while (!validAnswer) loop, if not valid, then bank = 0 / more versatile than Convert.ToInt32 because it allows you to know if the conversion succeeds or not / int = Int32
                if (!validAnswer) Console.WriteLine("Please enter digits only, no decimal.");
            }

            //Console.WriteLine("And how much money did you bring today?");
            //int bank = Convert.ToInt32(Console.ReadLine()); - original before adopting TryParse in above
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName); // string formatting
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, bank); // instantiate with two arguments as defined in constructor in Player class ==> create a new 'player' (mark #1) / value (playerName) for name parameter for Name property, value (bank) for beginningBalance parameter for property Balance
                player.Id = Guid.NewGuid(); // properly track the player with the global unique identifier
                using (StreamWriter file = new StreamWriter(@"C:\Users\jerry\Logs\log.txt", true)) // true = append (if you put mouse over 'StreamWriter', you will see 'bool append' in the place
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame(); // instantiate a game / polymorphism applies here / Game = base, detailed implementation uses TwentyOneGame as this game is TwentyOneGame
                game += player; // (game = game + player) we're adding player to the game via overloaded operator + (combine two objects together with operator overload) as defined in Player class
                player.isActivelyPlaying = true; // isActivelyPlaying = a property of player / will be used for while loop (while player is actively playing)

                while (player.isActivelyPlaying && player.Balance > 0) // *** (while true =) as long as the player's isActivelyPlaying value is true (answer 'yes' for play? question) AND player's balance is not empty amount, game on (run 'play' method in Game class)! 
                {
                    try
                    {
                        game.Play(); // play method in Game class / game = new game (instance)
                    }
                    catch (FraudException) // if it's an argument exception, this happens
                    {
                        Console.WriteLine("Security! Kick this person out"); // if bet is -100 for example
                        Console.ReadLine();
                        return;

                    }
                    catch (Exception) // Exception for other generic (all) exceptions
                    {
                        Console.WriteLine("An error occurred. Please contact your System Administrator.");
                        Console.ReadLine();
                        return; // also end the game, return ends the method (game.Play()) in the void method (static void Main(string[] args)) return nothing, it ends the method right here
                    }
                }

                game -= player; // happens after while loop exit
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Feel free to look around the casino. Bye for now"); // case if NO answered
            Console.Read(); // pause
        }
    }
}
