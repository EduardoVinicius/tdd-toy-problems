namespace InvoiceGenerator
{
    public class SystemClock : IClock
    {
        public DateTime Today()
        {
            return DateTime.Now;
        }
    }
}
