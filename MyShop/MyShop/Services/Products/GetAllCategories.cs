using MyShop.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Services.Products
{
    [Service]
    public class GetAllCategories
    {
        private IProductManager _productManager;

        public GetAllCategories(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public Response Do()
        {
            var categories = new List<string>();
            var products = _productManager.GetAllProducts();
            foreach (var product in products)
            {
                categories.Add(product.Category);
            }
            return new Response
            {
                Categories = categories.Distinct(),
            };
        }

        public class Response
        {
            public IEnumerable<string> Categories { get; set; }
        }
    }
}
