using System.Runtime.ConstrainedExecution;

namespace Producta.Secret
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
    }
}