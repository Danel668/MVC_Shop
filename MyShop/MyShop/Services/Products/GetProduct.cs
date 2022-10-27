using MyShop.Domain.Enums;
using MyShop.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Services.Products
{
    [Service]
    public class GetProduct
    {
        private IProductManager _productManager;

        public GetProduct(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public Response Do(string name)
        {
            var product = _productManager.GetProductByName(name);

            return new Response
            {
                Id = product.Id,
                Name = product.Name,
                Category = product.Category,
                Description = product.Description,
                Price = $"${product.Price}",
                Image = product.Image,

                Stock = product.Stock.Select(x => new StockViewModel
                {
                    Qty = x.Qty,
                    Color = x.Color,
                    Size = x.Size
                }).ToList()
            };
        }

        public class StockViewModel
        {
            public int Qty { get; set; }
            public ProductColor Color { get; set; }
            public ProductSize Size { get; set; }
        }

        public class Response
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Category { get; set; }
            public string Description { get; set; }
            public string Price { get; set; }
            public string Image { get; set; }

            public ICollection<StockViewModel> Stock { get; set; }
        }
    }
}
