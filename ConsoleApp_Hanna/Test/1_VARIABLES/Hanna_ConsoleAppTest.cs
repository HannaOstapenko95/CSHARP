using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VARIABLES_NAM;
using MAIN_NAM;

namespace PROGRAM_NAM
{
    [TestClass]
    public class CONTENT_TEST
    {
        [TestMethod]
        public void CheckReturnTrue_Content()
        {
            //Arrange
            bool expected = true;
            //Act
            bool actual = Program.Content();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculation_for_TestTest()
        {
            //Arrange
            Program calc = new Program();
            int x = 10;
            int y = 12;
            //Act
            int expected = 22; 
            int actual = calc.Calculation_for_Test(x, y);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }


}
