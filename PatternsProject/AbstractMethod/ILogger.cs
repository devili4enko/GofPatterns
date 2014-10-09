using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractMethod
{
    public interface ILogger
    {
        void Log(string message);
        void LogError(string message);
        void LogWarning(string message);
    }
}
