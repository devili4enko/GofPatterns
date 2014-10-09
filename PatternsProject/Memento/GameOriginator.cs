using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class GameOriginator
    {
        private GameState gameState = new GameState(100,0);

        public void Play()
        {
            gameState = new GameState((int)(gameState.Health*0.9), gameState.MonstersKill+2);
            Console.WriteLine(gameState.ToString());
        }

        public GameMemento SaveGame()
        {
            return new GameMemento(gameState);
        }

        public void LoadGame(GameMemento momento)
        {
            gameState = momento.GetState();
        }
    }
}
