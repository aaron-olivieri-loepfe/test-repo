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
            double expectedResult = 2;

            //Act
            double result = ClassOperation.Subtraction(9, 7);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            //Arrange
            MathLibrary ClassOperation = new MathLibrary();
            double expectedResult = 20;

            //Act
            double result = ClassOperation.Multiplication(5, 4);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestDivision()
        {
            //Arrange
            MathLibrary ClassOperation = new MathLibrary();
            double expectedResult = 3;

            //Act
            double result = ClassOperation.Division(27, 9);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestSquareRoot()
        {
            //Arrange
            MathLibrary ClassOperation = new MathLibrary();
            double expectedResult = 9;

            //Act
            double result = ClassOperation.SquareRoot(81);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestPerimeter()
        {
            //Arrange
            MathLibrary ClassOperation = new MathLibrary();
            double expectedResult = 31.41;

            //Act
            double result = ClassOperation.Perimeter(5);

            //Assert
            Assert.AreEqual(expectedResult, result, 0.01);
        }
    }
}