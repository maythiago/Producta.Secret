using System;
using Producta.Secret.Core.Service.Calculator;
using Xunit;


namespace Producta.Secret.Test
{
    public class CalculatorTest
    {
        private Calculator calc;
        public CalculatorTest()
        {
            calc = new CalculatorIterativeImpl();
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(7, 13)]
        [InlineData(11, 89)]
        [InlineData(17, 1597)]
        [InlineData(75, 2111485077978050)]
        public void given_index_then_return_fibonacci_value(int index, long expected)
        {
            var value = calc.GetFibonacci(index);
            Assert.Equal(expected, value);
        }

        [Theory]
        [InlineData(5, true)]
        [InlineData(78, true)]
        [InlineData(79, false)]
        public void given_index_then_validate_if_fibonacci_value_is_16_digits_above(int input, bool expected)
        {
            var value = calc.ValidateDigits(input);
            Assert.Equal(expected, value);
        }
    }
}
