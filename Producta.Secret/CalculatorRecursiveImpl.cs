namespace Producta.Secret
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
    }
}