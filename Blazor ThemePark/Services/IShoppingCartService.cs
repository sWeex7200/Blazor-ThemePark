using Blazor_ThemePark.Model;

namespace Blazor_ThemePark.Services
{
    public interface IShoppingCartService
    {
        List<ShopItem> ShoppingCartItems { get; }
        void AddToCart(ShopItem item);
        void ClearCart(); // Add this method
    }
}