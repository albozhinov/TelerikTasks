﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.LoggingModule
{
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
