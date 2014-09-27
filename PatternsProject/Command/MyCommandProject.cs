using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Command
{
    class MyCommandProject : ICommand
    {
        protected Team _team { get; set; }
        protected List<Requirement> _requirements { get; set; }

        public MyCommandProject(Team team, List<Requirement> requirements )
        {
            _team = team;
            _requirements = requirements;
        }

        public void Execute()
        {
            _team.CompleteProject(_requirements);
        }
    }
}
