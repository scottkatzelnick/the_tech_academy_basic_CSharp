using System;
using System.Collections.Generic;
using System.Linq;

namespace TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();
            Console.WriteLine("Place your bet!");

            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing. . .");
                foreach (Player player in Players)
                {
                    Console.Write($"{player.Name}: ");
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TWentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine($"BlackJack! {player.Name} wins {Bets[player]}!");
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TWentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has BlackJack! Everyone loses!");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("Your cards are:  ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine($"{card.ToString()}");
                    }
                    Console.WriteLine("\n\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);
                        bool busted = TWentyOneRules.isBusted(player.Hand);
                        if (busted)
                        {
                            Dealer.Balance += Bets[player];
                            Console.WriteLine($"{player.Name} Busted! You lost your bet, {Bets[player]}! Your new balance is {player.Balance}.");
                            Console.WriteLine("\nDo you want to play again?");
                            answer = Console.ReadLine().ToLower();
                            if (answer == "yes" || answer == "yea" || answer == "yeah" || answer == "y" || answer == "yup")
                            {
                                player.isActivelyPlaying = true;
                            }
                            else
                            {
                                player.isActivelyPlaying = false;
                            }
                        }
                    }
                }
            }
            Dealer.isBusted = TWentyOneRules.isBusted(Dealer.Hand);
            Dealer.Stay = TWentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer is hitting. . .");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TWentyOneRules.isBusted(Dealer.Hand);
                Dealer.Stay = TWentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying!");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine($"{entry.Key.Name} won {entry.Value}");
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                return;
            }
            //foreach (Player player in Players)
            //{
            //    bool? playerWon = TWentyOneRules.CompareHands(player.Hand, Dealer.Hand);
            //}
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 Players:");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
