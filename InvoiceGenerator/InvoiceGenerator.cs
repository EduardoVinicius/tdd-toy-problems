namespace InvoiceGenerator
{
    public class InvoiceGenerator
    {
        private readonly IList<IActionAfterInvoiceGeneration> _actions;
        private readonly IClock _clock;
        private readonly ITable _table;

        public InvoiceGenerator(IList<IActionAfterInvoiceGeneration> actions, IClock clock, ITable table)
        {
            _actions = actions;
            _clock = clock;
            _table = table;
        }

        public InvoiceGenerator(IList<IActionAfterInvoiceGeneration> actions, ITable table) : this(actions, new SystemClock(), table)
        {
        }

        public Invoice Generate(Order order)
        {
            Invoice invoice = new Invoice(order.Client, order.TotalValue * _table.ForValue(order.TotalValue), _clock.Today());

            foreach (var action in _actions)
            {
                action.Execute(invoice);
            }

            return invoice;
        }
    }
}
