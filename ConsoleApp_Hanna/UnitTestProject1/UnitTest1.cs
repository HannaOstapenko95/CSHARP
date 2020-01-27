using System;
using Xunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}*/
namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact] //attribute
        public void Test1()
        {
            /*//Arrange
            var x = 5;
            var y = 2;
            //Act
            var expected = 7;
            var actual = x + y;
            //Assert
            Assert.Equal(expected, actual);*/
            //arrange
            var book = new CLASSES_OBJECTS_M.Book.Book(" ");
            var book1 = new Book();
            //act
            //assert


        }
    }
}

