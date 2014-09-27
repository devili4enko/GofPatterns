using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class OrderDocumnentComponent : IDocumentComponent
    {
        private string order;

        public OrderDocumnentComponent(string order)
        {
            this.order = order;
        }

        public string GatherData()
        {
            return string.Format("<order>{0}</order>", order);
        }

        public void AddComponent(IDocumentComponent component)
        {
            Console.WriteLine("");
        }
    }
}
