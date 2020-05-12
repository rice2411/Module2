using NUnit.Framework;
using IsTriangle;
namespace IsTriangleTest
{
    public class Tests
    {
        private CheckTriangle test;
        [SetUp]
        public void Setup()
        {
            test = new CheckTriangle();
        }

        [Test]
        public void Test()
        {
            double s1 = -1;
            double s2 = -1;
            double s3 = -1;
            Assert.IsFalse(test.Istriangle(s1, s2, s3));
        }
    }
}