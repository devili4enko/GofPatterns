using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public interface IWallCreator
    {
        void CreateWindow(int count);
        void CreateDoor(bool doubleSide);
        void CreateWalls(double height);
    }
}
