using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public interface IDocumentComponent
    {
        string GatherData();
        void AddComponent(IDocumentComponent component);
    }
}
