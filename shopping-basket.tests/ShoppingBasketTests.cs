using System;
using NUnit.Framework;

namespace shopping_basket.tests
{
    public class ShoppingBasketTests
    {
        [Test]
        public void ShouldAddOneItemToShoppingBasket()
        {
            var shoppingBasket = new ShoppingBasket();
            shoppingBasket.Add("Bread");
            Assert.That(shoppingBasket.Total(), Is.EqualTo(1));
        }
    }
}