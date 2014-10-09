using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class Team 
    {
        protected string Name { get; set; }

        public Team(string name)
        {
            Name = name;
        }

        public void CompleteProject(List<Requirement> requirements)
        {
            foreach (var requirement in requirements)
            {
                Console.WriteLine(requirement.Task + " comleted by team " + Name);
            }
        }
    }
}
