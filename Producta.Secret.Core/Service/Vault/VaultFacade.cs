namespace Producta.Secret.Core.Service.Fibonacci
{
    public interface VaultFacade
    {
        Notification Validate(int input);
        string GetNextCode(int input);
    }
}