using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathMagician.Numbers;


namespace MathMagicianTests.Numbers
{
    [TestClass]
    public class NaturalNumberTests
    {
        // This is a sanity check
        // Ensures everything is hooked up correctly AND
        // that the permissions are correct.

        [TestMethod]
        public void EnsureICanCreateInstance()
        {
            NaturalNumber naturalNumber = new NaturalNumber();

            Assert.IsNotNull(naturalNumber);
        }

        [TestMethod]
        public void EnsureOneIsTheFirstNumber()
        {
            // Arrange (Where you set stuff up)
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act (Call the method that you are testing)
            int expectedResult = 1;
            int actualResult = naturalNumber.GetFirst();

            //Assert (Check the output of your method)
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetNext()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            int expectedResult = 4;
            //int myNum; --> default is zero "0"

            //This intentionally fails I guess?:
            //int actualResult = naturalNumber.GetNext(3);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void EnsureICanGetSequence()
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            int[] expectedResult = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] actualResult = naturalNumber.GetSequence(10);

            // Assert
            Assert.AreEqual(expectedResult.Length, actualResult.Length);    
        }

        [TestMethod]
        public void EnsureICanPrintSequence();
        {
            // Arrange
            NaturalNumber naturalNumber = new NaturalNumber();

            // Act
            string expectedResult = "1 2 3 4 5";
            // string actualResult = naturalNumber.PrintNumbers(new[] { 1, 2, 3, 4, 5 });
            // is the same as saying:
            int[] inputArray = new[] { 1, 2, 3, 4, 5 };
            string actualResult = naturalNumber.PrintNumbers(inputArray);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
