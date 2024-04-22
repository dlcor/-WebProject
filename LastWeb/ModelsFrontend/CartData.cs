using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LastWeb.ModelsFrontend
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