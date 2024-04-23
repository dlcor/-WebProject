using System.Collections.Generic;

namespace LastWeb.Domain.ModelsFrontend
{
    public class CartData
    {
        public List<ProductQuantity> Products { get; set; }

        public CartData()
        {
            Products = new List<ProductQuantity>(); 
        }
    }
}