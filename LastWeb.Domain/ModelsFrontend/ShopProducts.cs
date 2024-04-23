using System.Linq;
using LastWeb.Domain.Enums;

namespace LastWeb.Domain.ModelsFrontend
{
    public class ShopProducts
    {
        public SortByPrice SortByPrice { get; set; } = SortByPrice.None;
        public SortByGenre SortByGenre { get; set; } = SortByGenre.All;
        public ProductData[] products { get; set; }
    }
}