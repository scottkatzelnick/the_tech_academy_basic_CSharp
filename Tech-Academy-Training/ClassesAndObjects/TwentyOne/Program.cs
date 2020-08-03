using System;
using System.Collections.Generic;

// Namespace is a file structure construct- The directory this class lives in is called TwentyOne.
namespace TwentyOne
{
    // Class to run TwentyOne program
    internal class Program
    {
        // Main method calling on the Deck() method to create a randomly shuffled deck
        private static void Main(string[] args)
        {
            // Initialize Deck object called deck
            Deck deck = new Deck();

            // Apply the Shuffle() method to randomize order of the cards in the deck
            deck.Shuffle();

            // Prints every Card object to Console
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine("Cards in Deck = {0}", deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
