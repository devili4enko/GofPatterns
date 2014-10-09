using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public class LaptopShop
    {
        private AbstractLaptopBuilder _laptopBuilder;

        public void GetBuilder(AbstractLaptopBuilder _builder)
        {
            _laptopBuilder = _builder;
        }

        public Laptop GetLaptop()
        {
            return _laptopBuilder.GetLaptop();
        }

        public void MakeLaptop()
        {
            _laptopBuilder.CreateNewLaptop();
            _laptopBuilder.SetDVD();
            _laptopBuilder.SetHDD();
            _laptopBuilder.SetProcessor();
            _laptopBuilder.SetRAM();
            _laptopBuilder.SetResolution();
            _laptopBuilder.SetVideocard();
        }
    }
}
