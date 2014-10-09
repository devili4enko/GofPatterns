using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class LoggerSingleton
    {
        private LoggerSingleton() { }
        private int count = 0;
        public static LoggerSingleton instanceLoggerSingleton = null;

        public static LoggerSingleton GetInstance()
        {
            if (instanceLoggerSingleton == null)
            {
                instanceLoggerSingleton = new LoggerSingleton();
            }
            return instanceLoggerSingleton;
        }

        public void Log(string message)
        {
            Console.WriteLine("{0} logging: {1}", count, message);
            count++;
        }

    }
}
