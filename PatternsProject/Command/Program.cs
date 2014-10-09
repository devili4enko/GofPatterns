using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var _customer = new Customer();

            var team = new Team("Z");

            var requiremets = new List<Requirement> { new Requirement("Coolweb site"), new Requirement("Allows to order beer") };
            ICommand commandZ = new MyCommandProject(team, requiremets);

            _customer.AddCommand(commandZ);

            var _developer = new HeroDeveloper();
            ICommand commandA = new OneDeveloperCommand(_developer, "Orders");
            
            _customer.AddCommand(commandA);

            _customer.SignContractWithBoss();
        }
    }
}
