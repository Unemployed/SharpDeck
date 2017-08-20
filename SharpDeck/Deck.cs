using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SharpDeck
{

    public class SharpDeck : IEnumerable<Card>
    {
        Stack<Card> deck = new Stack<Card>();
        bool hasJokers = false;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="withJokers">Make the deck with two jokers.</param>
        /// <param name="shuffle">Shuffle the deck after making it.</param>
        public SharpDeck(bool withJokers, bool shuffle)
        {
            //Create The Deck
            MakeNormalDeck();
            hasJokers = withJokers;
            if (withJokers)
            {
                deck.Push(new Card("JJ"));
                deck.Push(new Card("JJ"));
            }

            if (shuffle)
            {
                Shuffle(DateTime.Now.Millisecond);
            }
        }

        /// <summary>
        /// Shuffles the deck object according to the Fisher–Yates Modern Shuffle.
        /// </summary>
        /// <param name="seed">Seed for RNG</param>
        public void Shuffle(int seed)
        {
            //Shuffle the Deck
            Random rng = new Random(seed);
            var pos = rng.Next(0, deck.Count);
            var list = deck.ToList();
            for (int i = 0; i < list.Count() - 1; i++)
            {
                pos = rng.Next(0, deck.Count);
                var swapout = list[pos];
                if (pos != i)
                {
                    list[pos] = list[i];
                    list[i] = swapout;
                }

            }
            deck = new Stack<Card>(list);
        }

        /// <summary>
        /// Removes and returns the top card of the deck.
        /// </summary>
        /// <returns>Top card of the deck</returns>
        public Card Deal()
        {
            //Deal the top card
            return deck.Pop();
        }

        /// <summary>
        ///Returns a card at a specified zero-based index.
        /// </summary>
        /// <param name="i">Zero based index position of a card in the deck.</param>
        /// <returns></returns>
        public Card this[int i]
        {
            get
            {
                return deck.ElementAt(i);
            }
        }

        public void MakeNormalDeck()
        {
            deck = new Stack<Card>();
            var CardValues = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            foreach (var suit in Enum.GetNames(typeof(Suit)))
            {
                var suitKey = suit[0];
                foreach (var val in CardValues)
                {
                    deck.Push(new Card(val + suitKey));
                }
            }
        }


        #region IEnumerable

        public IEnumerator<Card> GetEnumerator()
        {
            return deck.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return deck.GetEnumerator();
        }

        #endregion
    }
}
