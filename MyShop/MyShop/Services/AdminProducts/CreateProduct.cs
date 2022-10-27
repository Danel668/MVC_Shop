using Microsoft.AspNetCore.Http;
using MyShop.Domain.Interfaces;
using MyShop.Domain.Models;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MyShop.Services.AdminProducts
{
    [Service]
    public class CreateProduct
    {
        private IFileManager _fileManager;
        private IProductManager _productManager;

        public CreateProduct(IProductManager productManager, IFileManager fileManager)
        {
            _fileManager = fileManager;
            _productManager = productManager;
        }

        public async Task<Response> Do(Request request)
        {
            var product = new Product()
            {
                Name = request.Name,
                Category = request.Category,
                ShortDescription = request.ShortDescription,
                Description = request.Description,
                Price = request.Price,
            };

            if (request.Image != null)
            {
                product.Image = await _fileManager.SaveImage(request.Image);
            }
            else
                product.Image = null;

            if (await _productManager.CreateProduct(product) <= 0)
            {
                throw new Exception("Failed to create product");
            }

            return new Response
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }

        public class Request
        {
            [Required]
            public string Name { get; set; }
            [Required]
            public string Category { get; set; }
            [Required]
            public string ShortDescription { get; set; }
            [Required]
            public string Description { get; set; }
            [Required]
            public decimal Price { get; set; }
            [Required]
            public IFormFile Image { get; set; }
        }

        public class Response
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}
