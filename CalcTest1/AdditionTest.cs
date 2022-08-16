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
}
