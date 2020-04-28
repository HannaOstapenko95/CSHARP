using Microsoft.VisualStudio.TestTools.UnitTesting;
using TRY_CATCH_NAM;

namespace ConsoleCalculator.Tests.MSTest
{
    [TestClass]
    public class CalculatorShould
    {
        [TestMethod]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();
            Assert.ThrowsException<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));
            // Assert.ThrowsException<CalculationException>(() => sut.Calculate(1, 1, "+"));
            var ex = Assert.ThrowsException<CalculationOperationNotSupportedException>(() => sut.Calculate(1, 1, "+"));
            Assert.AreEqual("+", ex.Operation);
        }


    }
}
