using System;
using NUnit.Framework;

namespace shopping_basket.tests
{
    public class ShoppingBasketTests
    {
        private IShoppingBasket _shoppingBasket;

        [SetUp]
        public void SetupShoppingBasket()
        {
            _shoppingBasket = new ShoppingBasket();
        }
        
        [Test]
        public void ShouldAddOneItemToShoppingBasket()
        {
            _shoppingBasket.Add("Bread");
            Assert.That(_shoppingBasket.TotalItems(), Is.EqualTo(1));
        }

        [Test]
        public void ShouldTotalPriceOfBasket()
        {
            _shoppingBasket.Add("Bread");
            Assert.That(_shoppingBasket.TotalPrice(), Is.EqualTo(1));
        }
    }
}