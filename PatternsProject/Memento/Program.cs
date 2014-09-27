using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new CareTaker();

            game.Shoot();
            game.Shoot();
            game.Save();
            game.Shoot();
            game.Shoot();
            game.Shoot();
            game.Load();
            game.Shoot();
            game.Shoot();
        }
    }
}
