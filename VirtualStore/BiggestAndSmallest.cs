using VirtualStore;

namespace TDD
{
    public class BiggestAndSmallest
    {
        public Item Smallest { get; set; }
        public Item Biggest { get; set; }

        public void Find(ShoppingCart cart)
        {
            foreach (Item item in cart.Items)
            {
                if (Smallest == null || item.UnitValue < Smallest.UnitValue)
                    Smallest = item;

                if (Biggest == null || item.UnitValue > Biggest.UnitValue)
                    Biggest = item;
            }
        }
    }
}
