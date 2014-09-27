using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class DocumentComponent : IDocumentComponent
    {
        private string Name { get; set; }
        private List<IDocumentComponent> DocumentComponents { get; set; }

        public DocumentComponent(string name)
        {
            this.Name = name;
            DocumentComponents= new List<IDocumentComponent>();
        }
        
        public string GatherData()
        {
            var sb = new StringBuilder();

            sb.AppendLine(string.Format("<{0}>", Name));

            foreach (IDocumentComponent documentComponent in DocumentComponents)
            {
                sb.AppendLine(documentComponent.GatherData());
            }
            sb.Append(string.Format("</{0}>", Name));
            return sb.ToString();
        }

        public void AddComponent(IDocumentComponent component)
        {
           DocumentComponents.Add(component);
        }
    }
}
