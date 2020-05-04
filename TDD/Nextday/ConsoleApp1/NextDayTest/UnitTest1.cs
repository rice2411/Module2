using NUnit.Framework;

using nextday;
namespace NextDayTest
{
    public class Tests
    {
        private Nextday day;
        [SetUp]
        public void Setup()
        {
            day = new Nextday();
        }
        [Test]
        public void Test()
        {
            System.DateTime then = new System.DateTime(2001, 11, 24);
            Assert.AreEqual("25/11/2001", day.WhatIsTheNextDay(then));
        }
        [Test]
        public void Test1()
        {
            System.DateTime then = new System.DateTime(2001, 10, 31);
            Assert.AreEqual("1/11/2001",day.WhatIsTheNextDay(then));
            
        }
        [Test]
        public void Test2()
        {
            System.DateTime then = new System.DateTime(2001, 12, 31);
            Assert.AreEqual("1/1/2002", day.WhatIsTheNextDay(then));
        }
        [Test]
        public void Test3()
        {
            System.DateTime then = new System.DateTime(2001, 6, 30);
            Assert.AreEqual("1/7/2001", day.WhatIsTheNextDay(then));
        }
        [Test]
        public void Test4()
        {
            System.DateTime then = new System.DateTime(2020, 2, 28);
            Assert.AreEqual("29/2/2020", day.WhatIsTheNextDay(then));
        }
        [Test]
        public void Test5()
        {
            System.DateTime then = new System.DateTime(2020, 2, 29);
            Assert.AreEqual("1/3/2020", day.WhatIsTheNextDay(then));
        }
        [Test]
        public void Test6()
        {
            System.DateTime then = new System.DateTime(2019, 2, 28);
            Assert.AreEqual("1/3/2019", day.WhatIsTheNextDay(then));
        }
        
    }
}