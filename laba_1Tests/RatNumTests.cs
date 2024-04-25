using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba_1;

namespace laba_1.Tests
{
    [TestClass()]
    public class RatNumTests
    {
        [TestMethod()]
        public void sumTest()
        {
            RatNum r1 = new RatNum(5, 2);
            RatNum r2 = new RatNum(15, 3);

            RatNum sum = r1 + r2;
            RatNum mysum = new RatNum(15, 2);

            Assert.IsTrue(mysum == sum);
        }
        [TestMethod()]
        public void decTest()
        {
            RatNum r1 = new RatNum(5, 3);
            RatNum r2 = new RatNum(15, 3);

            RatNum sum = r2 - r1;
            RatNum mysum = new RatNum(10, 3);
            Assert.IsTrue(sum == mysum);
        }
        [TestMethod()]
        public void biggerTest()
        {
            RatNum r1 = new RatNum(5, 3);
            RatNum r2 = new RatNum(15, 3);
            Assert.IsTrue(r2 > r1);
        }
        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}