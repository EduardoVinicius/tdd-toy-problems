namespace TDD
{
    public class BiggestAndSmallest
    {
        public Product Smallest { get; set; }
        public Product Biggest { get; set; }

        public void Find(ShoppingCart cart)
        {
            foreach (Product product in cart.Products)
            {
                if (Smallest == null || product.Value < Smallest.Value)
                    Smallest = product;

                if (Biggest == null || product.Value > Biggest.Value)
                    Biggest = product;
            }
        }
    }
}
