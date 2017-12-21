using System;

namespace SharpDeck.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            SharpDeck deck = new SharpDeck();
            Console.WriteLine("There are " + deck.Cards.Count + " cards in this deck.");

            Player player1 = new Player(); // Player class for example only
            Player player2 = new Player();
            player1.hand = deck.Deal();
            player2.hand = deck.Deal();

            Console.WriteLine("Player 1 has the " + player1.hand.ToString() + ".");
            Console.WriteLine("Player 2 has the " + player2.hand.ToString() + ".");
            Console.Read();

        }
    }

    public class Player // Player class for example only
    {
        public Card hand;
    }
}
