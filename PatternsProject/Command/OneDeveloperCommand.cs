using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class OneDeveloperCommand : ICommand
    {
        protected HeroDeveloper _developer { get; set; }
        protected string _task { get; set; }

        public OneDeveloperCommand(HeroDeveloper developer, string task)
        {
            _developer = developer;
            _task = task;
        }

        public void Execute()
        {
            _developer.DoWork(_task);
        }
    }
}
