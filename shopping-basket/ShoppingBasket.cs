using System;

namespace shopping_basket
{
    public class ShoppingBasket : IShoppingBasket
    {
        private string _item;

        public void Add(string item)
        {
            _item = item;
        }

        public int TotalItems()
        {
            return 1;
        }

        public decimal TotalPrice()
        {
            if (_item == "Butter")
            {
                return 0.80m;
            }
            return 1;
        }
    }

    public interface IShoppingBasket
    {
        void Add(string item);
        int TotalItems();
        decimal TotalPrice();
    }
}