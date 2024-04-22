using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LastWeb.ModelsFrontend
{
    public class ProductData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public ReviewData[] ReviewDatas {  get; set; } 
    }
}