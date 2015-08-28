using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Singleton
{
    public class ThreadSafeSingleton
    {
        private ThreadSafeSingleton() { }
        private int count = 0;
        public static ThreadSafeSingleton instanceLoggerSingleton = null;

        private static object _lock = new object();
        /// <summary>
        /// GetInstance of singleton
        /// </summary>
        /// <returns></returns>
        public static ThreadSafeSingleton GetInstance()
        {
            if (instanceLoggerSingleton != null) return instanceLoggerSingleton;

            var temp = new ThreadSafeSingleton();
            Interlocked.CompareExchange(ref instanceLoggerSingleton, temp, null);

            return instanceLoggerSingleton;
        }

        /// <summary>
        /// Jus singleton method
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Console.WriteLine("{0} logging: {1}", count, message);
            count++;
        }
    }
}
