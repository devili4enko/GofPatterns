using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class CareTaker
    {
        private readonly GameOriginator _game = new GameOriginator();
        private readonly Stack<GameMemento> _memento = new Stack<GameMemento>();

        public void Shoot()
        {
            _game.Play();
        }

        public void Save()
        {
            _memento.Push(_game.SaveGame());
        }

        public void Load()
        {
            _game.LoadGame(_memento.Peek());
        }
    }
}
