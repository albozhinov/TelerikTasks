using Demo.RegistrationModule;
using Demo.LoggingModule;
using System;

namespace Demo.Main
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var service = new RegistrationService(new FileLogger());
            service.Run();
        }
    }
}
