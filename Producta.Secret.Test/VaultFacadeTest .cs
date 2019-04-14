using System.Linq;
using NSubstitute;
using Producta.Secret.Core.Service.Calculator;
using Producta.Secret.Core.Service.Fibonacci;
using Xunit;


namespace Producta.Secret.Test
{
    public class FibonacciFacadeTest
    {
        private VaultFacade _facade;
        private Calculator _calc;

        public FibonacciFacadeTest()
        {
            _calc = Substitute.For<Calculator>();
            _facade = new VaultFacadeImpl(_calc);
        }

        [Fact]
        public void given_fibonacci_digits_invalid_when_validate_then_return_error()
        {
            var errors = new Notification();
            errors.Errors.Add("Some error");
            _calc.ValidateDigits(Arg.Any<int>()).Returns(errors);

            var result = _facade.Validate(int.MaxValue);

            Assert.True(result.HasErrors);
            Assert.Equal("Some error", result.Errors.First());

        }
        
        [Fact]
        public void given_fibonacci_digits_valid_when_validate_then_return_no_error()
        {
            var errors = new Notification();
            _calc.ValidateDigits(Arg.Any<int>()).Returns(errors);

            var result = _facade.Validate(0);

            Assert.False(result.HasErrors);
        }

        [Theory]
        [InlineData("0000000000100001", 100001)]
        [InlineData("9999999999999999", 9999999999999999)]
        [InlineData("0123456789123456", 123456789123456)]
        public void given_valid_input_when_call_get_value_then_return_16_digits_value(string expected, long fibonacciMock)
        {
            _calc.GetFibonacci(Arg.Any<int>()).Returns(fibonacciMock);
           
            string result = _facade.GetNextCode(1);

            Assert.Equal(expected,result);
        }
    }
}