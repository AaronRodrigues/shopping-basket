using System;
using System.Collections.Generic;
using System.Linq;

namespace shopping_basket
{
    public class ShoppingBasket : IShoppingBasket
    {
        private IList<string> _items;

        public ShoppingBasket()
        {
            _items = new List<string>();
        }

        public void Add(string item)
        {
            _items.Add(item);
        }

        public int TotalItems()
        {
            return _items.Count;
        }

        public decimal TotalPrice()
        {
            var itemsGrouped = _items
                .GroupBy(x => x)
                .ToDictionary(item => item.Key, itemCount => itemCount.Count());

            var total = 0m;

            foreach (var item in itemsGrouped)
            {
                switch (item.Key)
                {
                    case "Bread":
                        total += item.Value * 1.0m;
                        break;
                    case "Butter":
                        total += item.Value * 0.80m;
                        break;
                    case "Milk":
                        total += item.Value * 1.15m;
                        break;
                }
            }

            var discountOnBread = ApplyBuy2ButterGetBreadAt50PercentOffDiscount(_items);
            var discountOnMilk = ApplyBuy3MilkandGetthe4thmilkforfreeDiscount(_items);
            var discountedTotal = total - discountOnBread - discountOnMilk;
            
            return discountedTotal;
        }

        private decimal ApplyBuy2ButterGetBreadAt50PercentOffDiscount(IList<string> _items)
            {
                var butterCount = _items.Count(x => x == "Butter");
                var discountableItems = butterCount / 2;
                var breadCount = _items.Count(x => x == "Bread");
                var totalItemsToBeDiscounted =  Math.Min(breadCount, discountableItems);
                var discount = totalItemsToBeDiscounted * 0.5m;
                return discount;
            }

        private decimal ApplyBuy3MilkandGetthe4thmilkforfreeDiscount(IList<string> _items)
            {
                var milkCount = _items.Count(x => x == "Milk");
                var discountableItems = Math.Floor( milkCount/4m);
                var totalItemsToBeDiscounted =  Math.Min(milkCount, discountableItems);
                var discount = totalItemsToBeDiscounted * 1.15m;
                return discount;
            }
    }

    public interface IShoppingBasket
    {
        void Add(string item);
        int TotalItems();
        decimal TotalPrice();
    }
}