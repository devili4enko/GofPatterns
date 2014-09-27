using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class HeaderDocumentElement : IDocumentComponent
    {
        public string GatherData()
        {
            return string.Format("<header>{0}</header>", DateTime.Now.ToShortDateString());
        }

        public void AddComponent(IDocumentComponent component)
        {
            Console.WriteLine("");
        }
    }
}
