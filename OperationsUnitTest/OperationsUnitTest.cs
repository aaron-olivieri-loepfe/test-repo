using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculationTests
{
    [TestClass]
    public class OperationTest
    {
        [TestMethod]
        public void TestAddition()
        {
            //Arrange
            MathLibrary ClassOperation = new MathLibrary();
            double expectedResult = 5;

            //Act
            double result = ClassOperation.Addition(2, 3);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            //Arrange
            MathLibrary ClassOperation = new MathLibrary();
            int expectedResult = 2;

            //Act
            int result = ClassOperation.Subtraction(9, 7);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            //Arrange
            MathLibrary ClassOperation = new MathLibrary();
            int expectedResult = 20;

            //Act
            int result = ClassOperation.Multiplication(5, 4);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            //Arrange
            MathLibrary ClassOperation = new MathLibrary();
            int expectedResult = 3;

            //Act
            int result = ClassOperation.Division(27, 9);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}

   





