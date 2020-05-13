using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using vitorBarbosa_S00185772;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Phone phonePrice = new Phone();

            double expectedResult = 600;

            phonePrice.phonePrice = 500;


            phonePrice.IncreasePrice();


            Assert.AreEqual(expectedResult, phonePrice.phonePrice);

        }
    }
}
