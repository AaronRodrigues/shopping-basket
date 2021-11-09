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

        [Test]
        public void ShouldReturn295WhenBasketContainsOneBreadOneButterAndOneMilk()
        {
            _shoppingBasket.Add("Bread");
            _shoppingBasket.Add("Butter");
            _shoppingBasket.Add("Milk");
            Assert.That(_shoppingBasket.TotalItems(), Is.EqualTo(3));
            Assert.That(_shoppingBasket.TotalPrice(), Is.EqualTo(2.95m));
        }

        [Test]
        public void ShouldReturn345WhenFourMilkInBasket()
        {
            _shoppingBasket.Add("Milk");
            _shoppingBasket.Add("Milk");
            _shoppingBasket.Add("Milk");
            _shoppingBasket.Add("Milk");
            Assert.That(_shoppingBasket.TotalItems(), Is.EqualTo(4));
            Assert.That(_shoppingBasket.TotalPrice(), Is.EqualTo(3.45));
        }
    }
}