using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple singleton
            var singletoneInstance = LoggerSingleton.GetInstance();
            singletoneInstance.Log("Test Started");

            var processor = new HardProcessor(1);
            processor.Process(111);
            singletoneInstance.Log("Test Ended");

            //Threadsafe singleton
            var singletoneInstanceThreadsafe = LoggerSingleton.GetInstance();
            singletoneInstanceThreadsafe.Log("Test Started");

            var processor2 = new SecondProcessor(52);
            processor2.Process(111);
            singletoneInstanceThreadsafe.Log("Test Ended");
        }
    }
}
