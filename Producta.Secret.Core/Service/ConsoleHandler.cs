using System;
using System.Linq;
using Producta.Secret.Core.Service.Fibonacci;

namespace Producta.Secret
{
    public class ConsolerHandler
        {
            private readonly VaultFacade _facade;
            public ConsolerHandler(VaultFacade facade)
            {
                _facade = facade;
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
                        notification.Errors = _facade.Validate(value).Errors;
                        if (!notification.HasErrors)
                        {
                            var nextCode = _facade.GetNextCode(value);
                            Console.WriteLine(nextCode);
                        }
                    }
                    else
                    {
                        notification.Errors.Add("The vault only accepts numeric digits.");
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
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
}