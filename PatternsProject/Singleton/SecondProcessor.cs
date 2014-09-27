using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class SecondProcessor
    {
         private int start;

         public SecondProcessor(int start)
        {
            this.start = start;
            ThreadSafeSingletonLogger.GetInstance().Log("Process Loaded");
        }

        public void Process(int end)
        {
            ThreadSafeSingletonLogger.GetInstance().Log("Process Started");
            int sum = 0;
            for (; start <= end; start++)
            {
                sum++;
            }
            ThreadSafeSingletonLogger.GetInstance().Log("Process Ended. Result: " + sum);
        }
    }
}
