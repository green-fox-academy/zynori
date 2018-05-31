using System;
using NUnit.Framework;
using Sum;

namespace TestEnviroment
{
    [TestFixture]
    public class Class1
    {
        [TestCase]
        public void Should()
        {
            Assert.AreEqual(Sums.Summing(), 6 );
        }
    }
}