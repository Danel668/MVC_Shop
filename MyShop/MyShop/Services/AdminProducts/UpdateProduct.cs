using Microsoft.AspNetCore.Http;
using MyShop.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MyShop.Services.AdminProducts
{
    [Service]
    public class UpdateProduct
    {
        private IFileManager _fileManager;
        private IProductManager _productManager;

        public UpdateProduct(IProductManager productManager, IFileManager fileManager)
        {
            _fileManager = fileManager;
            _productManager = productManager;
        }

        public async Task<Response> Do(Request request)
        {
            var product = _productManager.GetProductById(request.Id);

            product.Name = request.Name;
            product.Category = request.Category;
            product.ShortDescription = request.ShortDescription;
            product.Description = request.Description;
            product.Price = request.Price;
            if (request.Image == null)
            {
                product.Image = request.CurrentImage;
            }
            else
            {
                if (!string.IsNullOrEmpty(request.CurrentImage))
                    _fileManager.RemoveImage(request.CurrentImage);

                product.Image = await _fileManager.SaveImage(request.Image);
            }

            await _productManager.UpdateProduct(product);

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
            public int Id { get; set; }
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
            public string CurrentImage { get; set; }
        }

        public class Response
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}
