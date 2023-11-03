using VirtualStore;

namespace TDD
{
    public class ShoppingCart
    {
        public IList<Item> Items { get; set; }

        public ShoppingCart()
        {
            Items = new List<Item>();
        }

        public void Add(Item item)
        {
            Items.Add(item);
        }

        public double FindBiggestValue()
        {
            if (Items.Count == 0)
                return 0;

            double biggest = Items[0].TotalAmount;
            foreach (var item in Items)
            {
                if (biggest < item.TotalAmount)
                    biggest = item.TotalAmount;
            }

            return biggest;
        }
    }
}