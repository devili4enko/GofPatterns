using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class ThreadSafeSingletonLogger
    {
        private ThreadSafeSingletonLogger() { }
        private int count = 0;
        public static ThreadSafeSingletonLogger instanceLoggerSingleton = null;
        public static object locker = new object();

        public static ThreadSafeSingletonLogger GetInstance()
        {
            lock (locker)
            {
                if (instanceLoggerSingleton == null)
                {
                    instanceLoggerSingleton = new ThreadSafeSingletonLogger();
                }
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
