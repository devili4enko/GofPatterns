using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class HardProcessor
    {
        private int start;

        public HardProcessor(int start)
        {
            this.start = start;
            LoggerSingleton.GetInstance().Log("Process Loaded");
        }

        public void Process(int end)
        {
            LoggerSingleton.GetInstance().Log("Process Started");
            int sum = 0;
            for (; start <= end; start++)
            {
                sum++;
            }
            LoggerSingleton.GetInstance().Log("Process Ended. Result: " + sum);
        }
    }
}
