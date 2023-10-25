using Blazor_ThemePark.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Blazor_ThemePark.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private List<ShopItem> shoppingCart = new List<ShopItem>();

        public List<ShopItem> ShoppingCartItems => shoppingCart;

        public void AddToCart(ShopItem item)
        {
            // Debug statement to check if the item is being added
            Debug.WriteLine($"Adding item to the shopping cart: {item.Name}");

            shoppingCart.Add(item);

            Debug.WriteLine("Shopping cart contents after adding:");
            foreach (var cartItem in shoppingCart)
            {
                Debug.WriteLine($"Item: {cartItem.Name}");
            }
        }
    }
}
