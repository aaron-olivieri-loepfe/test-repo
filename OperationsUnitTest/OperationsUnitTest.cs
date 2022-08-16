using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace CalculationTests
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange
            Operation ClassOperation = new Operation();
            int expectedResult = 5;

            //Act
            int result = ClassOperation.Addition(2, 3);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }

    [TestClass]
    public class SubtractionTest
    {
        [TestMethod]
        public void TestMethod2()
        {

            //Arrange
            Operation ClassOperation = new Operation();
            int expectedResult = 2;

            //Act
            int result = ClassOperation.Subtraction(9, 7);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }


        [TestClass]
    public class MultiplicationTest
    {
        [TestMethod]
        public void TestMethod3()
        {

            //Arrange
            Operation ClassOperation = new Operation();
            int expectedResult = 20;

            //Act
            int result = ClassOperation.Multiplication(4, 5);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }

    [TestClass]
    public class DivisionTest
    {
        [TestMethod]
        public void TestMethod4()
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


