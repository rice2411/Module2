using NUnit.Framework;
using NUnitDemo;
namespace NUnitTest
{
    public class CalTest

    {
        private Cal caluclator;
        [SetUp]
        public void Setup()
        {
            caluclator = new Cal();
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual(2, caluclator.Add(1, 1));
        }
    }
}