using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class GameMemento
    {
        private readonly GameState _state;

        public GameMemento(GameState state)
        {
            _state = state;
        }

        public GameState GetState()
        {
            return _state;
        }
    }
}
