using System;

namespace AbstractMethod
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please choose logge:");
                Console.WriteLine("1. Test Logger");
                Console.WriteLine("2. Standart Logger");
                Console.WriteLine("3. Backup Logger");

                int res;

                int.TryParse(Console.ReadLine(), out res);

                var logger = LoggerProviderFactory.GetLogger((Loggers)res);

                Console.WriteLine("Testing logger {0}", logger);
                logger.Log("Test Message");
                logger.LogError("Test Error");
                logger.LogWarning("Test Warning");
            }
        }
    }
}
