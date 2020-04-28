using Xunit;
using TRY_CATCH_NAM;

namespace ConsoleCalculator.Tests.Xunit
{
    public class CalculatorShould
    {
        [Fact]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();
            Assert.Throws<CalculationOperationNotSupportedException>(
    () => sut.Calculate(1, 1, "+"));

            /*Assert.Throws<CalculationException>(
() => sut.Calculate(1, 1, "+"));*/
            Assert.ThrowsAny<CalculationOperationNotSupportedException>(
    () => sut.Calculate(1, 1, "+"));

            var ex = Assert.Throws<CalculationOperationNotSupportedException>(
    () => sut.Calculate(1, 1, "+"));
            Assert.Equal("+", ex.Operation);
        }
    }
}
