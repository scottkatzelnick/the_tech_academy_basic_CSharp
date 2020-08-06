namespace TwentyOne
{
    public struct Card
    {
        public Suit Suit { get; set; } // Creates Card property Suit

        public Face Face { get; set; } // Creates Card property Face
    }

    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
