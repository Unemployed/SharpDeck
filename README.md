# SharpDeck
C# Library for a generic deck of cards

### Current functionalty includes:
- Jokers
- Shuffling
- Dealing Top Card
- Peeking Top Card
- Indexer access


##### Example Usage
Add SharpDeck to your project references.

```C#
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
```

##### Contributing
- Feel free to contribute. Fork & make a pull request
- Unit tests currently have ~97% coverage. Please write tests for your contributions.
