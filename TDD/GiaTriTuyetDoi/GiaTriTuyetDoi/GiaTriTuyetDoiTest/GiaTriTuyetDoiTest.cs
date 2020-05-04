using NUnit.Framework;
using GiaTriTuyetDoi;
namespace GiaTriTuyetDoiTest
{
    public class Tests
    {
        private GTTD gttd;
        [SetUp]
        public void Setup()
        {
            gttd = new GTTD();
        }

        [Test]
        public void TestFindAbsolute0()
        {
            int number = 0;
            int expected = 0;
            int result = gttd.FindAbsolute(number);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void TestFindAbsolute1()
        {
            int number = 1;
            int expected = 1;

            int result = gttd.FindAbsolute(number);
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestFindAbsoluteNegative1()
        {
            int number = -1;
            int expected = 1;

            int result = gttd.FindAbsolute(number);
            Assert.AreEqual(expected, result);
        }
    }
}