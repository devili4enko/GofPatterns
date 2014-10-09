using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy
{
    interface IWearingStratery
    {
        string weather { get; set; }
        string GetClothes();
        string GetAccessories();
    }
}
