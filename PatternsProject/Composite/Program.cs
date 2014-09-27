using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new DocumentComponent("Document");
            var header = new HeaderDocumentElement();
            var body = new DocumentComponent("Body");
            document.AddComponent(header);
            document.AddComponent(body);

            var customer = new CustomerDocumentComponent(42);
            body.AddComponent(customer);

            var orders = new DocumentComponent("Orders");
            var order0 = new OrderDocumnentComponent("order0, order101, order 102");
            var order1 = new OrderDocumnentComponent("order1");
            var order2 = new OrderDocumnentComponent("order2");
            var order3 = new OrderDocumnentComponent("order3");
            orders.AddComponent(order0);
            orders.AddComponent(order1);
            orders.AddComponent(order2);
            orders.AddComponent(order3);
            
            body.AddComponent(orders);
            var data = document.GatherData();

            Console.WriteLine(data);
        }
    }
}
