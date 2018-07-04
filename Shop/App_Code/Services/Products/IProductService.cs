using System.Collections.Generic;
using Services.Products.Dto;

namespace Services.Products
{
    public interface IProductService
    {
        List<ProductDto> GetProducts();
        ProductDto GetProducts(int id);
    }
}
