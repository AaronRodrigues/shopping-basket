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
        
        [TestCase("Bread", 1)]
        [TestCase("Butter", 0.80)]
        [TestCase("Milk", 1.15)]
        public void ShouldEnsureOneOfEachItemCostsRight(string item, decimal expectedPrice)
        {
            _shoppingBasket.Add(item);
            Assert.That(_shoppingBasket.TotalPrice(), Is.EqualTo(expectedPrice));
        }
    }
}