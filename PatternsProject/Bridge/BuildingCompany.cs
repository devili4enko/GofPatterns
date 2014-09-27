using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    public class BuildingCompany : IBuildingCompany
    {  
        public void CreateFoundation()
        {
            Console.WriteLine("Foundation Created");
        }

        public void CreateRoof()
        {
            Console.WriteLine("Roof Created");
        }

        public void CreateRoom()
        {
            WallCreator.CreateDoor(true);
            WallCreator.CreateWalls(2.8);
            WallCreator.CreateWindow(2);
        }
        
        public IWallCreator WallCreator{get;set;}
    }
}
