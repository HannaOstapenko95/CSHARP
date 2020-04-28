using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TRY_CATCH_NAM;

namespace ConsoleCalculator.Tests.Nunit
{
    public class CalculatorShould
    {
        [Test]
        public void ThrowWhenUnsupportedOperation()
        {
            var sut = new Calculator();
            Assert.That(() => sut.Calculate(1, 1, "+"),
                Throws.TypeOf<CalculationOperationNotSupportedException>());

            Assert.That(() => sut.Calculate(1, 1, "+"),
                Throws.TypeOf<CalculationOperationNotSupportedException>()
                .With.Property("Operation").EqualTo("+"));

            Assert.That(() => sut.Calculate(1, 1, "+"),
               Throws.InstanceOf<CalculationException>());

            Assert.Throws<CalculationOperationNotSupportedException>(
                () => sut.Calculate(1,1,"+"));

            var ex = Assert.Throws<CalculationOperationNotSupportedException>(
                () => sut.Calculate(1, 1, "+"));
            Assert.That(ex.Operation, Is.EqualTo("+"));
            //Will Fail
            /*Assert.That(() => sut.Calculate(1, 1, "+"),
              Throws.TypeOf<CalculationException>());*/
        }
    }
}
