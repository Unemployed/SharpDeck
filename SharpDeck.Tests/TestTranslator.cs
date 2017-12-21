using NUnit.Framework;
namespace SharpDeck.Tests
{
    [TestFixture]
    public class TestTranslator
    {
        [Test]
        public void TestTranslate()
        {
            Card a = new Card(Rank.Ace, Suit.Spades);
            Assert.AreEqual("Ace of Spades", a.ToString());

            Card b = new Card(Rank.Ten, Suit.Hearts);
            Assert.AreEqual("Ten of Hearts", b.ToString());

            Card c = new Card(Rank.Three, Suit.Clubs);
            Assert.AreEqual("Three of Clubs", c.ToString());

            Card d = new Card(Rank.King, Suit.Diamonds);
            Assert.AreEqual("King of Diamonds", d.ToString());

            Card joker = new Card(Rank.Joker, Suit.Clubs);
            Assert.AreEqual("Joker", joker.ToString());
        }
    }
}
