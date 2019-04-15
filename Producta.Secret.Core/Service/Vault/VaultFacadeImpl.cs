
namespace Producta.Secret.Core.Service.Fibonacci
{
    public class VaultFacadeImpl: VaultFacade
    {
        private readonly Calculator.Calculator _calc;
        public VaultFacadeImpl(Calculator.Calculator calc)
        {
            _calc = calc;
        }

        public Notification Validate(int input)
        {
            var errors = _calc.ValidateDigits(input);
            return errors;
        }

        public string GetNextCode(int input)
        {
            var fibonacci = _calc.GetFibonacci(input);
            return fibonacci.ToString().PadLeft(16, '0');
        }
    }
}