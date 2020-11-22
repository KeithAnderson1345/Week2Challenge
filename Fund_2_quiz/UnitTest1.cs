using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fund_2_quiz
{
    [TestClass]
    public class UnitTest1
    {
        public double GetSumOfTwoNumbers(double x, double y) => x + y;

        [TestMethod]
        public void GetSumOfTwoNumbers()
        {
            var actual = GetSumOfTwoNumbers(1, 4);
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }
    }
}
