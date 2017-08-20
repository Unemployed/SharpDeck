using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpDeck;
namespace SharpDeck.Tests
{
    [TestFixture]
    public class TestTranslator
    {
        [Test]
        public void TestTranslate()
        {
            Card s = new Card("AS");
            Assert.AreEqual("Ace of Spades", s.ToString());

            Card h = new Card("10H");
            Assert.AreEqual("Ten of Hearts", h.ToString());

            Card d = new Card("KD");
            Assert.AreEqual("King of Diamonds", d.ToString());

            Card c = new Card("3C");
            Assert.AreEqual("Three of Clubs", c.ToString());

        }
    }
}
