using Microsoft.VisualStudio.TestTools.UnitTesting;
using prog._3;
using System;

namespace UnitTest1
{
    [TestClass]
    public class Calculation_ab
    {
        [TestMethod]
        public void TestSumOfMultiplesOf17AndDivisibleBy4Mod2_Success()
        {
            // Arrange
            ex2 instance = new ex2(1, 100);

            // Act
            int result = instance.SumOfMultiplesOf17AndDivisibleBy4Mod2();

            // Assert
            Assert.AreEqual(34, result);
        }

        [TestMethod]
        public void TestSumOfMultiplesOf17AndDivisibleBy4Mod2_ZeroResult()
        {
            // Arrange
            ex2 instance = new ex2(1, 16);

            // Act
            int result = instance.SumOfMultiplesOf17AndDivisibleBy4Mod2();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSumOfMultiplesOf17AndDivisibleBy4Mod2_ErrorResult()
        {
            // Arrange
            ex2 instance = new ex2(100, 1);

            // Act
            int result = instance.SumOfMultiplesOf17AndDivisibleBy4Mod2();

            // Assert
            Assert.AreEqual(-1, result);
        }
    }
}
