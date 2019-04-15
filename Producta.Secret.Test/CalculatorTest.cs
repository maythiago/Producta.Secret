using System;
using System.Linq;
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
        [InlineData(79, "The fibonacci value of input cannot exceed 16 digits.")]
        [InlineData(-5, "The fibonacci index could not be negative.")]
        public void given_invalid_index_then_return_error(int input, string expected)
        {
            var value = calc.ValidateDigits(input);
            Assert.Equal(expected, value.Errors.First());
        }
        [Theory]
        [InlineData(78)]
        [InlineData(5)]
        [InlineData(0)]
        public void given_valid_index_then_return_empty_errors(int input)
        {
            var value = calc.ValidateDigits(input);
            
            Assert.Empty(value.Errors);
        }
    }
}
