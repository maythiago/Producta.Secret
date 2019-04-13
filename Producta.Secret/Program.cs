using System;
using System.Collections;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Producta.Secret.Core.Service.Calculator;

namespace Producta.Secret
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var calc = new CalculatorIterativeImpl();
            new ConsolerHandler(calc).Execute();
        }

        class ConsolerHandler
        {
            private readonly Calculator _calc;
            public ConsolerHandler(Calculator calc)
            {
                _calc = calc;
            }
            public void Execute()
            {
                int i = 0;
                while (i < 7)
                {
                    Notification notification = new Notification();
                    Console.WriteLine("Type the vault code:");
                    var readLine = Console.ReadLine();
                    Int32 value;
                    bool isNum = Int32.TryParse(readLine, out value);
                    if (isNum)
                    {
                        if (_calc.ValidateDigits(value))
                        {
                            var fibonacci = _calc.GetFibonacci(value);
                            Console.WriteLine(fibonacci);
                        }
                        else
                        {
                            notification.Errors.Add("The fibonacci value of index can't be more than 16 digits");
                        }
                    }
                    else
                    {
                        notification.Errors.Add("The vault only accepts numeric digits");
                    }
                    if (notification.HasErrors)
                    {
                        Console.WriteLine(notification.Errors.First());
                    }
                    else
                    {
                        i++;
                    }
                }
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
        }
    }
}