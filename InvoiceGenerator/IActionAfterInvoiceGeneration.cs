namespace InvoiceGenerator
{
    public interface IActionAfterInvoiceGeneration
    {
        void Execute(Invoice invoice);
    }
}
