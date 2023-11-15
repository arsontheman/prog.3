using Microsoft.VisualStudio.TestTools.UnitTesting;
using prog._3;
using System;

namespace UnitTest1
{
    [TestClass]
    public class Calculation_abcTest
    {
        [TestMethod]
        public void TestCountMultiplesOf27()
        {
            // Arrange
            int[] numbers = new int[] { 27, 54, 81 };
            var calculator = new ex1(numbers);

            // Act
            int result = calculator.CountMultiplesOf27();

            // Assert
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestCountMultiplesOf27WithNoMultiples()
        {
            // Arrange
            int[] numbers = new int[] { 7, 12, 14 };
            var calculator = new ex1(numbers);

            // Act
            int result = calculator.CountMultiplesOf27();

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestCountMultiplesOf27WithEmptyArray()
        {
            // Arrange
            int[] numbers = new int[] { };
            var calculator = new ex1(numbers);

            // Act
            int result = calculator.CountMultiplesOf27();

            // Assert
            Assert.AreEqual(0, result);
        }
    }
}
