using NUnit.Framework;

namespace SharpDeck.Tests
{
    [TestFixture]
    public class TestSharpCard
    {
        [Test]
        public void TestIsJoker()
        {
            var jokerCard = new Card(Rank.Joker, Suit.Diamonds);
            Assert.That(jokerCard.IsJoker);

            var card2 = new Card(Rank.Three, Suit.Clubs);
            Assert.IsFalse(card2.IsJoker);
        }
    }
}
