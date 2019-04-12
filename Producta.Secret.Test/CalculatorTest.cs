using System;
using Xunit;
using Producta.Secret;

namespace Producta.Secret.Test
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(7, 13)]
        [InlineData(11, 89)]
        [InlineData(17, 1597)]
        [InlineData(75, 2111485077978050)]
        public void given_index_then_return_fibonacci_value(int index, long expected)
        {
            Calculator calc = new CalculatorIterativeImpl();

            var value = calc.GetFibonacci(index);

            Assert.Equal(expected, value);
        }
    }
}
