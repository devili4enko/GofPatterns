using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class GameState
    {
        public int Health { get; set; }
        public int MonstersKill { get; set; }

        public GameState(int health, int monsterKill)
        {
            Health = health;
            MonstersKill = monsterKill;
        }

        public override string ToString()
        {
            return string.Format("Current health {0}, monsters killed {1}", Health, MonstersKill);
        }
    }
}
