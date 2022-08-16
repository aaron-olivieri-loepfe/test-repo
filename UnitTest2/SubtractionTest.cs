using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;


namespace CalculationTests
{
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
}
