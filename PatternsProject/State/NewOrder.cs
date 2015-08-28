using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace State
{
    class NewOrder : OrderState
    {
        public NewOrder(Order order)
            : base(order)
        {
        }

        public override void AddProduct()
        {
            _order.AddProduct();
        }

        public override void Cancel()
        {
            //_order.Cancel();
            //_order.SetOrderState(new Cancel(_order));
        }
    }
}
