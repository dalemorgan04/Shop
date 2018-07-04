using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Products.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RetailPrice { get; set; }
        public int SellingPrice { get; set; }
    }
}
