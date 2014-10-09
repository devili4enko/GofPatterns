using System;

namespace Composite
{
    public class CustomerDocumentComponent : IDocumentComponent
    {
        private int CustomerID { get; set; }

        public CustomerDocumentComponent(int id)
        {
            CustomerID = id;
        }

        public string GatherData()
        {
            string customerData;
            switch (CustomerID)
            {
                case 41:
                    customerData = "user with ID 41";
                    break;
                case 42:
                    customerData = "user with ID 42";
                    break;
                default:
                    customerData = "default user";
                    break;
            }

            return string.Format(@"<Customer>{0}</Customer>", customerData);
        }

        public void AddComponent(IDocumentComponent component)
        {
            Console.WriteLine("Nothing to add");
        }
    }
}
