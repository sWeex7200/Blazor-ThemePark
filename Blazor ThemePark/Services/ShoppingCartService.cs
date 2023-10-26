using Blazor_ThemePark.Model;

namespace Blazor_ThemePark.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private List<ShopItem> shoppingCart = new List<ShopItem>();
        public List<ShopItem> ShoppingCartItems { get; } = new List<ShopItem>();

        public void AddToCart(ShopItem item)
        {
            ShoppingCartItems.Add(item);
        }

        public void ClearCart()
        {
            ShoppingCartItems.Clear();
        }
    }
}
