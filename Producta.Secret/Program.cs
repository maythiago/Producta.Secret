using Producta.Secret.Core.Service.Calculator;
using Producta.Secret.Core.Service.Fibonacci;

namespace Producta.Secret
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new CalculatorIterativeImpl();
            var facade = new VaultFacadeImpl(calc);
            new ConsolerHandler(facade).Execute();
        }
    }
}