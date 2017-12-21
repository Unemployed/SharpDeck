namespace SharpDeck
{
    public class Card
    {
        private Suit _suit { get; set; }
        private Rank _rank { get; set; }

        public Card(Rank rank, Suit Suit)
        {
            this._suit = Suit;
            this._rank = rank;
        }

        public bool IsJoker
        {
            get
            {
                return this._rank == 0;
            }
        }

        public Rank Rank
        {
            get
            {
                return this._rank;
            }
        }

        public Suit Suit
        {
            get
            {
                return this._suit;
            }
        }

        public override string ToString()
        {
            return CodeTranslator.Translate(this);
        }

    }

    public enum Rank
    {
        Joker = 0,
        Two = 2,
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

    public enum Suit { Clubs, Spades, Diamonds, Hearts }
}