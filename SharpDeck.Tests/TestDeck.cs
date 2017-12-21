using NUnit.Framework;
using System;
using System.Linq;

namespace SharpDeck.Tests
{
    [TestFixture]
    public class TestDeck
    {
        const int CARDS_IN_DECK = 52;
        const int CARDS_IN_DECK_JOKERS = 54;

        [Test]
        public void TestCreate()
        {
            SharpDeck deck = new SharpDeck(false, false);
            Assert.AreEqual(CARDS_IN_DECK, deck.Cards.Count());
        }

        [Test]
        public void TestCreateWithJokers()
        {
            SharpDeck deck = new SharpDeck(false, true);
            Assert.AreEqual(CARDS_IN_DECK_JOKERS, deck.Cards.Count());
        }

        [Test]
        [Retry(3)] //3rd time's the charm
        public void TestCreateWithShuffle()
        {
            SharpDeck shuffled_deck = new SharpDeck(true, false);
            SharpDeck shuffled_deck2 = new SharpDeck(true, false);
            SharpDeck unshuffled = new SharpDeck(false, false);
            Assert.AreEqual(CARDS_IN_DECK, shuffled_deck.Cards.Count());

            Assert.Multiple(() =>
            {
                Assert.False(shuffled_deck.SequenceEqual(unshuffled)); //(1 in 52!) chance this fails
                Assert.False(shuffled_deck.SequenceEqual(shuffled_deck2)); //(1 in 52!) chance this fails
            }); //If both sequences are equal you should buy some lottery tickets
        }

        [Test]
        public void TestPeek()
        {
            SharpDeck deck = new SharpDeck();
            Assert.AreEqual(CARDS_IN_DECK, deck.Cards.Count()); //Prerequisite
            var card = deck.Peek();
            Assert.AreEqual(CARDS_IN_DECK, deck.Cards.Count());
        }

        [Test]
        public void TestDeal()
        {
            SharpDeck deck = new SharpDeck();
            Assert.AreEqual(CARDS_IN_DECK, deck.Cards.Count()); //Prerequisite

            var card = deck.Deal();
            Assert.AreEqual(CARDS_IN_DECK - 1, deck.Cards.Count());
            Assert.False(deck.Contains(card));
        }

        [Test]
        public void TestIndicie()
        {
            SharpDeck deck = new SharpDeck();
            Assert.That(deck[0] is Card);
            Assert.Throws<ArgumentOutOfRangeException>(new TestDelegate(() => deck[53].ToString()));
        }
    }
}
