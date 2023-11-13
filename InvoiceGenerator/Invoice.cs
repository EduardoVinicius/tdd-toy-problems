namespace InvoiceGenerator
{
    public class Invoice
    {
        public string Client { get; private set; }
        public double Value { get; private set; }
        public DateTime Date { get; private set; }

        public Invoice(string client, double value, DateTime date)
        {
            Client = client;
            Value = value;
            Date = date;
        }
    }
}
