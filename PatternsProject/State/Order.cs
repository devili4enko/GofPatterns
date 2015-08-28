using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace State
{
    class Order
    {
        private OrderState _state;
        private List<Product>  _products = new List<Product>();

        public Order()
        {
            _state = new NewOrder(this);
        }

        public void SetOrderState(OrderState state)
        {
            _state = state;
        }

        public void PrintOrderState()
        {
            Console.WriteLine(_state.GetType().Name);
        }

        public void AddProduct()
        {
            Console.WriteLine("Product has been added");
            _products.Add(new Product("testProduct"));
        }

        public void Ship()
        {
            //_state.Ship();
        }
    }

    class Product
    {
        public string Name { get; set; }

        public Product(string Name)
        {
            this.Name = Name;
        }
    }
}
