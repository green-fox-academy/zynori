using System;
using NUnit.Framework;
using Apples;


namespace TestEnviroment
{
    [TestFixture]
    public class Class1
    {
        [TestCase]
        public void ShouldGetTheAppleString()
        {
            Assert.AreEqual(Apple.GetApple(), "apple");
        }
    }
}
