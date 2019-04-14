namespace Producta.Secret.Core.Service.Calculator
{
    public class CalculatorRecursiveImpl : Calculator
    {
        public long GetFibonacci(int input)
        {
            if (input < 2)
            {
                return input;
            }
            return GetFibonacci(input - 1) + GetFibonacci(input - 2);
        }

        public Notification ValidateDigits(int input)
        {
            throw new System.NotImplementedException();
        }
    }
}