
namespace Producta.Secret.Core.Service.Calculator
{
    public class CalculatorIterativeImpl : Calculator
    {
        public long GetFibonacci(int index)
        {
            if (index == 0)
            {
                return 0;
            }

            if (index == 1 || index == 2)
            {
                return 1;
            }

            long fib = 0;
            long prevFib = 1;
            for (int i = 0; i < index; i++)
            {
                var temp = fib + prevFib;
                prevFib = fib;
                fib = temp;
            }
            return fib;
        }

        public bool ValidateDigits(int input)
        {
            // The last value with 16 digits are 78
            return input <= 78;
        }
    }
}