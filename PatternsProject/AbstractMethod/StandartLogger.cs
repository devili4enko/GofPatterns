using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractMethod
{
    public class StandartLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log to ProductionDB: {0}", message);
        }

        public void LogError(string message)
        {
            Console.WriteLine("Log Error to ProductionDB: {0}", message);
        }

        public void LogWarning(string message)
        {
            Console.WriteLine("Log Warning to ProductionDB: {0}", message);
        }
    }
}
