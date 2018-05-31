using System;
using NUnit.Framework;
using Anagram;

namespace TestEnviroment
{
    [TestFixture]
    public class Test
    {
        InputString anagram;

        [SetUp]
        public void SetUp()
        {
            anagram = new InputString();
        }

        [TestCase("Abba", "Abba")]
        public void IsItAnagram(string first, string second)
        {
            Assert.AreEqual(true, anagram.IsItAnagram(first, second));
        }

        [TestCase("Aleb", "Bela")]
        public void IsItReverse(string first, string second)
        {
            Assert.AreEqual(true, anagram.IsItAnagram(first, second));
        }

        [TestCase("", "")]
        public void IsItEmpty(string first, string second)
        {
            Assert.AreEqual(true, anagram.IsItAnagram(first, second));
        }

        [TestCase(null, null)]
        public void IsItNull(string first, string second)
        {
            Assert.Throws<NullReferenceException>(() => anagram.IsItAnagram(first, second));
        }
    }
}