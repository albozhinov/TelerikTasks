using System;
using System.IO;

using Demo.LoggingModule;

namespace Demo.RegistrationModule
{
    public class RegistrationService
    {
        private ILogger logger;

        public RegistrationService(ILogger logger)
        {
            this.logger = logger;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    RegisterUser();
                }
                catch (ArgumentException ex)
                {
                    logger.Log(ex.Message);
                }
            }
        }

        private void RegisterUser()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            var user = new User(username, password);
            Console.WriteLine($"User '{username}' added.\n");
        }
    }
}
