using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace CalculationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            //Arrange
            Operation ClassOperation = new Operation();
            int expectedResult = 5;

            //Act
            int result = ClassOperation.Sum(2, 3);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
