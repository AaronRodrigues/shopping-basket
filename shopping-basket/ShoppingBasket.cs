using System;

namespace shopping_basket
{
    public class ShoppingBasket : IShoppingBasket
    {
        public void Add(string item)
        {
           
        }

        public int TotalItems()
        {
            return 1;
        }

        public decimal TotalPrice()
        {
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