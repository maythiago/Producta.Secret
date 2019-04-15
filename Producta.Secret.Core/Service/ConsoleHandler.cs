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
                int value;
                bool isNum = int.TryParse(readLine, out value);
                if (isNum)
                {
                    notification.Errors = _facade.Validate(value).Errors;
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
                    var nextCode = _facade.GetNextCode(value);
                    Console.WriteLine(nextCode);
                    i++;
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}