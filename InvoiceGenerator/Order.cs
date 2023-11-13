namespace InvoiceGenerator
{
    public class Order
    {
        public string Client { get; private set; }
        public double TotalValue { get; private set; }
        public int ItemsQuantity { get; private set; }

        public Order(string client, double totalValue, int itemsQuantity)
        {
            Client = client;
            TotalValue = totalValue;
            ItemsQuantity = itemsQuantity;
        }
    }
}
