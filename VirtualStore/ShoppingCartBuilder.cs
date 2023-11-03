using TDD;

namespace VirtualStore
{
    public class ShoppingCartBuilder
    {
        public ShoppingCart cart;

        public ShoppingCartBuilder()
        {
            cart = new ShoppingCart();
        }

        public ShoppingCartBuilder WithItems(params double[] values)
        {
            foreach (double value in values)
            {
                cart.Add(new Item("item", 1, value));
            }
            return this;
        }

        public ShoppingCart Build()
        {
            return cart;
        }
    }
}
