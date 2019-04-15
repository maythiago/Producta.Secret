namespace Producta.Secret.Core.Service.Calculator
{
  public interface Calculator
    {
        long GetFibonacci(int input);
        Notification ValidateDigits(int input);
    }
}