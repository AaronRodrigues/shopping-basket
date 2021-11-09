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
        public void Giventhebaskethas1bread1butterand1milkwhenItotalthebasketthenthetotalshouldbe2Pounds95p()
        {
            _shoppingBasket.Add("Bread");
            _shoppingBasket.Add("Butter");
            _shoppingBasket.Add("Milk");
            Assert.That(_shoppingBasket.TotalItems(), Is.EqualTo(3));
            Assert.That(_shoppingBasket.TotalPrice(), Is.EqualTo(2.95m));
        }

        [Test]
        public void ShouldReturn3Pounds45pWhenFourMilkInBasket()
        {
            _shoppingBasket.Add("Milk");
            _shoppingBasket.Add("Milk");
            _shoppingBasket.Add("Milk");
            _shoppingBasket.Add("Milk");
            Assert.That(_shoppingBasket.TotalItems(), Is.EqualTo(4));
            Assert.That(_shoppingBasket.TotalPrice(), Is.EqualTo(3.45m));
        }

        [Test]
        public void Giventhebaskethas2Butterand2BreadwhenItotalthebasketthenthetotalshouldbe3Pounds10p()
        {
            _shoppingBasket.Add("Butter");
            _shoppingBasket.Add("Butter");
            _shoppingBasket.Add("Bread");
            _shoppingBasket.Add("Bread");
            Assert.That(_shoppingBasket.TotalItems(), Is.EqualTo(4));
            Assert.That(_shoppingBasket.TotalPrice(), Is.EqualTo(3.10m));
        }

        [Test]
        public void Giventhebaskethas2Butter1Breadand8MilkwhenItotalthebasketthenthetotalshouldbe9()
        {
            _shoppingBasket.Add("Butter");
            _shoppingBasket.Add("Butter");
            _shoppingBasket.Add("Bread");
            _shoppingBasket.Add("Milk");
            _shoppingBasket.Add("Milk");
            _shoppingBasket.Add("Milk");
            _shoppingBasket.Add("Milk");
            _shoppingBasket.Add("Milk");
            _shoppingBasket.Add("Milk");
            _shoppingBasket.Add("Milk");
            _shoppingBasket.Add("Milk");
            Assert.That(_shoppingBasket.TotalPrice(), Is.EqualTo(9.0m));
        }
    }
}