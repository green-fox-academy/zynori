using System;
using NUnit.Framework;


namespace TestEnviroment
{
    [TestFixture]
    public class Class1
    {
        [TestCase]
        public void WorksOrNot()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
