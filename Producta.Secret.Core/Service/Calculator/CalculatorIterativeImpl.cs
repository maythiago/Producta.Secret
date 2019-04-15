
namespace Producta.Secret.Core.Service.Calculator
{
    public class CalculatorIterativeImpl : Calculator
    {
        public long GetFibonacci(int input)
        {
            if (input == 0)
            {
                return 0;
            }

            if (input == 1 || input == 2)
            {
                return 1;
            }

            long fib = 0;
            long prevFib = 1;
            for (int i = 0; i < input; i++)
            {
                var temp = fib + prevFib;
                prevFib = fib;
                fib = temp;
            }
            return fib;
        }

        public Notification ValidateDigits(int input)
        {
            var errors =  new Notification();
            if (input < 0)
            {
                errors.Errors.Add("The fibonacci index could not be negative.");
            }
            // The last value with 16 digits are 78
            if (input > 78)
            {
                errors.Errors.Add("The fibonacci value of input cannot exceed 16 digits.");
            }
            return errors;
        }
    }
}