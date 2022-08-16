using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;


namespace CalculationTests
{
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
}
