using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Customer
    {
        protected List<ICommand> Commands { get;  set; }

        public Customer()
        {
            Commands = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            Commands.Add(command);
        }

        public void SignContractWithBoss()
        {
            foreach (var command in Commands)
            {
                command.Execute();
            }
        }
    }
}
