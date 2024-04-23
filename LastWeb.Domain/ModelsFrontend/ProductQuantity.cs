using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LastWeb.Domain.ModelsFrontend
{
    public class ProductQuantity
    {
       public int Quantity {get; set;}
       public ProductData ProductData { get; set;}
    }
}