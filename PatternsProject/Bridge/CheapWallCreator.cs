using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class CheapWallCreator : IWallCreator
    {
        public void CreateWindow(int count)
        {
            Console.WriteLine("created {0} windows, price {1} ", count, count * 5.75);
        }

        public void CreateDoor(bool doubleSide)
        {
            Console.WriteLine("created {0} door, price {1} ", doubleSide ? "Double side" : "Single side", doubleSide ? 10 * 2 : 10);
        }

        public void CreateWalls(double height)
        {
            Console.WriteLine("created {0} walls, price {1} ", height, height * 5.75);
        }
    }
}
