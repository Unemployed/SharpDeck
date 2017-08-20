namespace SharpDeck
{
    public class Card
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public Suit Suit { get; set; }
        public Card(string cardCode)
        {
            Code = cardCode;
            Value = cardCode.Substring(0, cardCode.Length - 1);
        }

        public Card(string Value, Suit Suit)
        {
            Code = Value + Suit.ToString();
        }

        public override string ToString()
        {
            return CodeTranslator.Translate(this);
        }

        public string ToShortString()
        {
            return Code; // "4H" "QH" "JD"
        }

    }

    public enum Suit { Clubs, Spades, Diamond, Hearts }
}