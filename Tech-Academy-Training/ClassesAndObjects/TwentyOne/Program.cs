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
            // Apply the Shuffle() method to randomize order(index) of the cards in the deck
            int timesShuffled = 0;
            deck = Shuffle(deck: deck, out timesShuffled, times: 13);
            // Named parameters are optional, but make method calls easier to read (i.e. deck: deck,
            // times: 1)

            // Prints every Card object to Console
            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine("Cards in Deck = {0}", deck.Cards.Count);
            Console.WriteLine("Times Shuffled = {0}", timesShuffled);
            Console.ReadLine();
        }

        // Shuffle() method that randomizes the cards order in the deck.Cards List. Optional
        // parameters can be set the paremter equal to an "initial value"
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            // Accounts for shuffle "times" parameter
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                // Creates temporary List and random object
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                // Iterate through deck.Cards List until empty and add cards to TempList randomly indexed
                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                // Returns shuffled cards back to deck.Cards List
                deck.Cards = TempList;
            }
            return deck;
        }
    }
}
