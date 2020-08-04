using System;
using System.Collections.Generic;

namespace TwentyOne
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Game game = new TwentyOneGame();
            game.Players = new List<Player>();
            Player player = new Player();
            player.Name = "Scott";
            game += player;
            game -= player;

            Deck deck = new Deck(); // Initialize Deck object called deck

            deck.Shuffle(3); // Apply the Shuffle() method to randomize order of the cards in the deck

            foreach (Card card in deck.Cards) // Cards is a List containing all cards
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine("Cards in Deck = {0}", deck.Cards.Count);

            Console.ReadLine();
        }
    }
}
