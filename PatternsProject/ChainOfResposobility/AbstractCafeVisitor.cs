using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainOfResposobility
{
    abstract class AbstractCafeVisitor
    {
        public AbstractCafeVisitor CafeVisitor { get; private set; }

        public AbstractCafeVisitor(AbstractCafeVisitor cafeVisitor)
        {
            CafeVisitor = cafeVisitor;
        }

        public virtual void HandleFood(Food food)
        {
            if (CafeVisitor != null)
            {
                CafeVisitor.HandleFood(food);
            }
            
        }
    }
}
