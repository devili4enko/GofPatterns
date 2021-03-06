﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractMethod
{
    public class BackupLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log to BackupDB: {0}", message );
        }

        public void LogError(string message)
        {
            Console.WriteLine("Log Error to BackupDB: {0}", message);
        }

        public void LogWarning(string message)
        {
            Console.WriteLine("Log Warning to BackupDB: {0}", message);
        }
    }
}
