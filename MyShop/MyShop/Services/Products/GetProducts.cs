using MyShop.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Services.Products
{
    [Service]
    public class GetProducts
    {
        private IProductManager _productManager;

        public GetProducts(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public IEnumerable<Response> Do()
        {
            return _productManager.GetAllProducts().Select(x => new Response
            {
                Name = x.Name,
                Category = x.Category,
                ShortDescription = x.ShortDescription,
                Price = $"${x.Price}",
                RealPrice = x.Price,
                Image = x.Image,
            });
        }

        public class Response
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public string ShortDescription { get; set; }
            public string Price { get; set; }
            public decimal RealPrice { get; set; }
            public string Image { get; set; }
        }
    }
}
