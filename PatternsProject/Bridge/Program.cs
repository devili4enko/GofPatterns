using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge 
{
    class Program
    {
        static void Main(string[] args)
        {
            var buildingCompany = new BuildingCompany();
            var expensiveWallCreator = new ExpensiveWallCreator();
            var cheapWallCreator = new CheapWallCreator();

            //заказ на Елитный дом
            buildingCompany.WallCreator = expensiveWallCreator;

            buildingCompany.CreateFoundation();
            buildingCompany.CreateRoom();
            buildingCompany.CreateRoof();

            //Поступает заказ на не очень дорогой домик
            buildingCompany.WallCreator = cheapWallCreator;

            buildingCompany.CreateFoundation();
            buildingCompany.CreateRoom();
            buildingCompany.CreateRoof();
        }
    }
}
