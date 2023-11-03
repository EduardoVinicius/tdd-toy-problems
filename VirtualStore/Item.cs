namespace VirtualStore
{
    public class Item
    {
        public string Description { get; private set; }
        public int Quantity { get; private set; }
        public double UnitValue { get; private set; }

        public Item(string description, int quantity, double unitValue)
        {
            Description = description;
            Quantity = quantity;
            UnitValue = unitValue;
        }

        public double TotalAmount 
        { 
            get
            {
                return UnitValue * Quantity;
            }
        }
    }
}
