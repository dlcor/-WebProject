using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LastWeb.Enums;
using LastWeb.ModelsFrontend;

namespace LastWeb.ModelsFrontend
{
    public class ShopProducts
    {
        public SortByPrice SortByPrice { get; set; } = SortByPrice.None;
        public SortByGenre SortByGenre { get; set; } = SortByGenre.All;
        public ProductData[] products { get; set; }
    }
}