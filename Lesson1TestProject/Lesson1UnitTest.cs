using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using COMP123_S2016_Lesson1B;

namespace Lesson1TestProject
{
    /**
     * This class is to test Lesson 1 project
     * @ class Lesson1UnitTest
     * 
     */
    [TestClass]
    public class Lesson1UnitTest
    {
        /**
         * Unit Test for OutputStringToConsole method of program class
         * 
         * @method OutputStringToConsoleTestMethod
         */
        [TestMethod]
        public void OutputStringToConsoleTestMethod()
        {
            //Arrange
            string outputString = "Enter User Name";
            bool hasNewLine= false;
            string actualResult;
            string expectedResult= "Enter Name: ";

            //Act
            actualResult = Program.OutputStringToConsole(outputString, hasNewLine);
                
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
