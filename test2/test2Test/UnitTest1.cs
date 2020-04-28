using System;
using Xunit;
using Calculator;
using System.Linq;
using System.Collections.Generic;
using test2;
//XUnit Project
namespace test2Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("42", 42)]
        [MemberData(nameof(Values))]
        public void should_sum_numbers(string numbers, int expected)
        {
            //Arrange
            var calculator = new StringCalculator();
            //Act
            var result = calculator.Add(numbers);
            //Assert
            //result.Should().Be(0);
            Assert.Equal(expected, result);
        }
    
        [Fact]
        public void should_return_0_for_empty_string()
        {
            //Arrange
            var calculator = new StringCalculator();
            //Act
            var result = calculator.Add("");
            //Assert
            //result.Should().Be(0);
            Assert.Equal(0, result);
            //Assert.Equal(1, 2);
            //1.Should().Be(2);
        }
        [Fact]
        public void should_return_42_for_empty_string()
        {
            //Arrange
            var calculator = new StringCalculator();
            //Act
            var result = calculator.Add("42");
            //Assert
            //result.Should().Be(0);
            Assert.Equal(42, result);
            //Assert.Equal(1, 2);
            //1.Should().Be(2);
        }

        [Fact]
        public void should_return_42_for_31_and_11()
        {
            //Arrange
            var calculator = new StringCalculator();
            //Act
            var result = calculator.Add("31, 11");
            //Assert
            //result.Should().Be(0);
            Assert.Equal(42, result);
            //Assert.Equal(1, 2);
            //1.Should().Be(2);
        }

        [Fact]
        public void should_return_sum_of_any_number_67_for_31_and_11()
        {
            //Arrange
            var calculator = new StringCalculator();
            //Act
            var result = calculator.Add("31, 11, 12, 15");
            //Assert
            //result.Should().Be(0);
            Assert.Equal(69, result);
            //Assert.Equal(1, 2);
            //1.Should().Be(2);
        }
        [Fact]
        public void should_support_new_lines()
        {
            //Arrange
            var calculator = new StringCalculator();
            //Act
            var result = calculator.Add("1 \n2,3");
            //Assert
            //result.Should().Be(0);
            Assert.Equal(6, result);
            //Assert.Equal(1, 2);
            //1.Should().Be(2);
        }

        [Fact]
        public void should_support_custom_delimiters()
        {
            //Arrange
            var calculator = new StringCalculator();
            //Act
            var result = calculator.Add("//;\n1;2");
            //Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void should_throw_exception_for_negatives()
        {
            //Arrange
            var calculator = new StringCalculator();
            //Act
            //xunit
            var e = Assert.Throws<Exception>(() => calculator.Add("1,2,-5,-6,7"));
            //Assert
            //result.Should().Be(0);
            Assert.Equal("negatives not allowed -5,-6", e.Message);

            //FluentAssertions
            //calculator.Invoking(_ => _.Add("1,2,-5,-6,7"))
            //    .Should().ThrowExactly<Exception>()
            //    .WithMessage("negatives not allowed -5,-6");
        }
        public static IEnumerable<object[]> Values()
        {
            return Enumerable.Range(1, 1000).Select(i => new object[] { i.ToString(), i });
            //yield return new object[] { "", 0 };
        }   
    }
}
