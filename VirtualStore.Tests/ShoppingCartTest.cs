using TDD;

namespace VirtualStore.Tests
{
    [TestFixture]
    public class ShoppingCartTest
    {
        private ShoppingCart _cart;

        [SetUp]
        public void SetUp()
        {
            _cart = new ShoppingCart();
        }

        [Test]
        public void ShouldReturnZeroIfCartIsEmpty()
        {
            Assert.That(_cart.FindBiggestValue(), Is.EqualTo(0).Within(0.0001));
        }

        [Test]
        public void ShouldReturnItemValueIfCartHas1Element()
        {
            _cart.Add(new Item("Refrigerator", 1, 900.0));

            Assert.That(_cart.FindBiggestValue(), Is.EqualTo(900.0).Within(0.0001));
        }

        [Test]
        public void ShouldReturnBiggestValueIfCartHasManyElements()
        {
            _cart.Add(new Item("Refrigerator", 1, 900.0));
            _cart.Add(new Item("Stove", 1, 1500.0));
            _cart.Add(new Item("Washing machine", 1, 750.0));

            Assert.That(_cart.FindBiggestValue(), Is.EqualTo(1500.0).Within(0.0001));
        }
    }
}
