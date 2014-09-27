using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    interface IBuildingCompany
    {
        void CreateFoundation();
        void CreateRoof();
        void CreateRoom();
        

        IWallCreator WallCreator { get; set; }
    }
}
