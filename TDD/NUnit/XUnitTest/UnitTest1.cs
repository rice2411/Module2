using System;
using Xunit;
using NUnitDemo;
namespace XUnitTest
{
    public class UnitTest1
    {
        private Cal cal;
        public void UnitTest1()
        {
            cal = new Cal();
        }
        [Fact]
        public void Test1(int val)
        {
            var rs = cal.Add(1, 1);
            Assert.Equal(2,rs);
        }
        [Theory]
        [InlineData(2)]

    }
}
