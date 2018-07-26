using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Demo.LoggingModule
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            File.AppendAllText("log.txt", message);
        }
    }
}
