using System;
using Xunit;
using MAIN_NAM;
using VARIABLES_NAM;

namespace XUnitTestProject1
{
    public class XUnitHanna_ConsoleAppTest
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var x = 5;
            var y = 2;
            //Act
            var expected = 7;
            var actual = x + y;
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Test2()
        {

            //Arrange
            Program vars = new Program();
            int x = 7;
            int y = 3;
            int expected = 10;
            //Act
            int actual = vars.Calculation_for_Test(x, y);
            //Assert
            Assert.Equal(expected, actual);
            
        }
    }
}
