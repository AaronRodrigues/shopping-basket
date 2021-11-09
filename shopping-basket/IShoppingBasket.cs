namespace shopping_basket
{
    public interface IShoppingBasket
    {
        void Add(string item);
        int TotalItems();
        decimal TotalPrice();
    }
}