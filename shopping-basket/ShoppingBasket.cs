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
                        total += 1.0m;
                        break;
                    case "Butter":
                        total += 0.80m;
                        break;
                    case "Milk":
                        total += 1.15m;
                        break;
                }
            }

            return total;
        }
    }

    public interface IShoppingBasket
    {
        void Add(string item);
        int TotalItems();
        decimal TotalPrice();
    }
}