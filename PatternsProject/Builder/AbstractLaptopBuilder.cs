using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Builder
{
    public abstract class AbstractLaptopBuilder
    {
        protected Laptop Laptop { get; private set; }

        public void CreateNewLaptop()
        {
            Laptop= new Laptop();
        }

        public Laptop GetLaptop()
        {
            return Laptop;
        }

        public abstract void SetResolution();
        public abstract void SetHDD();
        public abstract void SetRAM();
        public abstract void SetDVD();
        public abstract void SetVideocard();
        public abstract void SetProcessor();
        
     }

}
