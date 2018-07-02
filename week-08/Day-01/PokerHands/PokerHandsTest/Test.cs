using System;
using NUnit.Framework;
using PokerHands;

namespace PokerHandsTest
{
    [TestFixture]
    public class Test
    {
        Poker poker = new Poker();

        [Test]
        public void CheckIfSplitInputIs12()
        {
            string input = "Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH";
            bool output = poker.CheckInputLength12(input);
            Assert.AreEqual(true, output);
        }

        [Test]
        public void GetHand()
        {
            string input = "Black: 2H 3D 5S 9C KD White: 2C 3H 4S 8C AH";
            string output = poker.GetHands(input);
            Assert.AreEqual("White wins", output);
        }
    }
}