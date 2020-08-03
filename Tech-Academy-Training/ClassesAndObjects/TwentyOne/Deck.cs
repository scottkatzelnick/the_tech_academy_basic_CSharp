using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() // Deck constructor for creating a deck object(List) with 52 uniques card objects
        {
            Cards = new List<Card>(); // Initialize an empty list of cards

            // A List of all possible suits
            List<string> Suits = new List<string>()
            {
                "Clubs",
                "Hearts",
                "Diamonds",
                "Spades"
            };

            // A List of all possible faces
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    /* Calls on the Card class to create a new card object, then initializing the
                       new card object the properties suit and face. Next, it adds the card to the
                       aforementioned empty Card List.

                       **Total Card objects created equals 52 (4 suits x 13 faces)** */

                    Card card = new Card() { Face = face, Suit = suit }; // Object Initialization
                    Cards.Add(card);
                }
            }
        }

        // This is the Cards "property" of the Deck class.
        public List<Card> Cards { get; set; }

        // Shuffle() method that randomizes the cards order in the deck.Cards List. Optional
        // parameters can be set the paremter equal to an "initial value"
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList; // Returns shuffled cards back to the Cards List
            }
        }
    }
}
