using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    abstract class OrderState
    {
        public Order _order;

        protected OrderState(Order order)
        {
            _order = order;
        }

        public virtual void AddProduct()
        {
            OperationNotAllowed("AddProduct");
        }

        public virtual void ShipProduct()
        {
            OperationNotAllowed("ShipProduct");
        }

        public virtual void NewOrder()
        {
            OperationNotAllowed("NewOrder");
        }

        public virtual void Register()
        {
            OperationNotAllowed("Register");
        }

        public virtual void Cancel()
        {
            OperationNotAllowed("Cancel");
        }

        public virtual void Invoice()
        {
            OperationNotAllowed("Invoice");
        }

        public virtual void Granted()
        {
            OperationNotAllowed("Granted");
        }

        private void OperationNotAllowed(string opName)
        {
            Console.WriteLine("{0} no allowed at {1} state", opName, this.GetType().Name);
        }
    }
}
