using System.Collections.Generic;
using System.Threading;
using Antlr.Runtime.Misc;
using Models;
using Repository;
using Services.Products.Dto;

namespace Services.Products
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository repository;

        public ProductService()
        {
            this.repository = new ProductRepository();
        }

        public List<ProductDto> GetProducts()
        {
            List<Product> products = repository.Get();
            List<ProductDto> productDtos = new List<ProductDto>();
            foreach (var product in products)
            {
                var productDto = new ProductDto()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    ImageUrl = product.ImageUrl,
                    RetailPrice = product.RetailPrice,
                    SellingPrice = product.SellingPrice
                };
                productDtos.Add(productDto);
            }
            return productDtos;
        }

        public ProductDto GetProducts(int id)
        {
            Product product = repository.Get(id);
            ProductDto productDto = new ProductDto()
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                RetailPrice = product.RetailPrice,
                SellingPrice = product.SellingPrice
            };
            return productDto;
        }
    }
}
