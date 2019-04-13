namespace Producta.Secret.Core.Service.Calculator
{
    public class CalculatorRecursiveImpl : Calculator
    {
        public long GetFibonacci(int index)
        {
            if (index < 2)
            {
                return index;
            }
            return GetFibonacci(index - 1) + GetFibonacci(index - 2);
        }

        public bool ValidateDigits(int input)
        {
            throw new System.NotImplementedException();
        }
    }
}