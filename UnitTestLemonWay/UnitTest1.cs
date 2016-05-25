using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLemonWay
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFibonnaci()
        {
            using (WSLemonWay.Service ws = new WSLemonWay.Service())
            {
                int fibN = 10;
                int result = 0;
                int resultExpected = 55;

                result = ws.Fibonacci(fibN);
                Assert.AreEqual(result, resultExpected, "La suite de Fibonacci de rang 10 est correcte");
            }
        }
    }
}
