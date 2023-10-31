using static Blazor_ThemePark.Pages.Stores.ConfirmOrder;

namespace Blazor_ThemePark.Model
{
    public class Order
    {
        public int OrderID { get; set; }
        public OrderDetails UserDetails { get; set; } = null!;
        public List<ShopItem> Items { get; set; } = null!;
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
