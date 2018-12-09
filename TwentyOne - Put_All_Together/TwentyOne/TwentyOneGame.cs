using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneGame: Game, IWalkAway // Game: base class inheritance example, IWalkAway: interface inheritance example
    {
        public TwentyOneDealer Dealer { get; set; } // property 'TwentyOneDealer Dealer' specific to TwentyOneGame / Q: *TwentyOneDealer* class or type ?

        public override void Play() // method / an inheriting class must implement Game.play as Game.play (base) is defined in the *abstract* class 'Game' / to implement more customized method, so we add *override*
        {
            Dealer = new TwentyOneDealer(); // start for this method code / instantiate a new dealer for TwentyOne game specific (we made TwentyOneDealer class for Dealer class, however we didn't for Player class - instructor's choice)
            foreach (Player player in Players) // run thru all players / Players is a property of Game class, Player: object type, player: instance (object)
            {
                player.Hand = new List<Card>(); // ensure Hand is empty () / instantiate
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>(); // initialize Dealer's hand, empty ()
            Dealer.Stay = false;
            Dealer.Deck = new Deck(); // initialize Dealer's deck (start a new deck = refresh the deck for every single round)
            Dealer.Deck.Shuffle(); // shuffle cards after all those initialized
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players) // loop thru each player to place a bet
            {
                int bet = Convert.ToInt32(Console.ReadLine()); // user enter his bet / bet method in Player.cs
                bool succcessfullyBet = player.Bet(bet); // true or false return from Player.Bet method with integer bet (for 'int amount' parameter)
                if (!succcessfullyBet) // = (successfullyBet == false)
                {
                    return; // we don't return anything (for it's void method) but we end this method
                }
                Bets[player] = bet; // for Dealer to effectively track player:bet use 'dictionary' method from "public Dictionary<Player, int> Bets { get; set; } in Game.cs" / put it in Game class because it can be common to any game
            }
            for (int i = 0; i < 2; i++) // deal card twice for each player
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players) // foreach loop useful for list
                {
                    Console.Write("{0}: ", player.Name); // player: instance, Name: property
                    Dealer.Deal(player.Hand); // give two cards to a player (player.Hand) / Dealer: class, Deal: method, player.Hand: argument (so check player.Hand if blackjack or not)
                    if (i ==1) // need to check if blackjack once the second card is given
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand); // TwentyOneRules: class, CheckForBlackJack: method, player.Hand: argument
                        if (blackJack)
                        {
                            Console.WriteLine("BlackJack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); // player earns
                            return; // end this method
                        }
                    }
                }
                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack) // dealer can also have blackjack
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets) // KeyValuePair: dictionary remember all its key:pair value
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay") // stay = sit
                    {
                        player.Stay = true;
                        break; // we break the loop and check the condition in while loop (outer loop)
                    }
                    else if (answer == "hit") // hit for another card from dealer
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand); // also need to check if busted
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?");
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.isActivelyPlaying = true; // remember game.Play() only runs when player.isActivelyPlaying = true (see Program.cs)
                            return; 
                        }
                        else
                        {
                            player.isActivelyPlaying = false;
                            return; // return just ends the void function -> back to game.Play() in Program.cs
                        }
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); // set the base by check if dealer is busted
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); // set the base if dealer stays or not before while loop
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand); // if this is true, while loop ends or
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand); // if this is true, while loop ends
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Buested!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value); // Key = player, this player won this amount
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2); // Players is list, lambda expression, player earns
                    Dealer.Balance -= entry.Value; // dealer loses
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); // useful if more than 2 answers but when still wants to use boolean (true, false, null)
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins."); // Tie
                    player.Balance += Bets[player]; // give money (bet) back to player
                    // Bets.Remove(player); // remove bets table / we actually don't need it because we reset the base everytime the game starts
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                    player.Balance += (Bets[player] * 2); // player earns (bets * 2)
                    Dealer.Balance -= Bets[player]; // dealer loses
                }
                else // dealer won
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play again?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.isActivelyPlaying = true;
                }
                else
                {
                    player.isActivelyPlaying = false;
                }
            }
        }
        public override void ListPlayers() // override virtual method
        {
            Console.WriteLine("21 Players:"); // added to test the override
            base.ListPlayers();
        }
        public void WalkAway(Player player) // (forced to) implement a specified method in an interface (IWalkAway)
        {
            throw new NotImplementedException();
        }
    }
}
