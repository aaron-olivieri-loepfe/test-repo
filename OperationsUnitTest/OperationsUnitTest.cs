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
            Operation ClassOperation = new Operation();
            int expectedResult = 5;

            //Act
            int result = ClassOperation.Addition(2, 3);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            //Arrange
            Operation ClassOperation = new Operation();
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
            Operation ClassOperation = new Operation();
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
            Operation ClassOperation = new Operation();
            int expectedResult = 3;

            //Act
            int result = ClassOperation.Division(27, 9);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}

   





