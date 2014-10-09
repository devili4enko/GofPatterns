using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractMethod
{
    public class LoggerProviderFactory
    {
        public static ILogger GetLogger(Loggers loggers)
        {
            switch (loggers)
            {
                case Loggers.BackupLogger:
                    return new BackupLogger();
                case Loggers.StandartLogger:
                    return new StandartLogger();
                case Loggers.TestLogger:
                    return new TestLogger();
                default:
                    return new StandartLogger();

            }
        }
    }
}
