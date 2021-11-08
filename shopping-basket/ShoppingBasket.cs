using System;

namespace shopping_basket
{
    public class ShoppingBasket : IShoppingBasket
    {
        public void Add(string item)
        {
           
        }

        public int Total()
        {
            return 1;
        }
    }

    public interface IShoppingBasket
    {
        void Add(string item);
        int Total();
    }
}