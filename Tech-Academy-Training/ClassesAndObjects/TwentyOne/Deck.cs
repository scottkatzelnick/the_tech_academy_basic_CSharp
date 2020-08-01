using System.Collections.Generic;

namespace TwentyOne
{
    // Create class Deck which is a List holding Card objects
    public class Deck
    {
        // Deck method for creating a deck object(List) with 52 uniques card objects
        public Deck()
        {
            // Initialize an empty list of cards
            Cards = new List<Card>();

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

            // For each face in the List - Faces
            foreach (string face in Faces)
            {
                // Matched up with each suit in the List - Suits
                foreach (string suit in Suits)
                {
                    // Calls on the Card class to create a new card object Assigning the new card
                    // the properties suit and face Adds the card to the aforementioned empty Card List
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
                // **Total iterations equals total possible suit/face matches**
                // **Total Card objects created equals 52 (4 suits x 13 faces)**
            }
        }

        // Creates a List for the Deck class containg all the Card objects i.e. Deck deck = new
        // Deck(); deck.Cards equates to this List
        public List<Card> Cards { get; set; }
    }
}
