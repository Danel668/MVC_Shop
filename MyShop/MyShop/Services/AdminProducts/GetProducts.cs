using MyShop.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Services.AdminProducts
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
                Id = x.Id,
                Name = x.Name,
                Price = x.Price
            });
        }

        public class Response
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}
