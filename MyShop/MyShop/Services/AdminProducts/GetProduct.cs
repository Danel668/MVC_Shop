using MyShop.Domain.Interfaces;

namespace MyShop.Services.AdminProducts
{
    [Service]
    public class GetProduct
    {
        private IProductManager _productManager;

        public GetProduct(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public Response Do(int id)
        {
            var product = _productManager.GetProductById(id);

            return new Response
            {
                Name = product.Name,
                Category = product.Category,
                ShortDescription = product.ShortDescription,
                Description = product.Description,
                Price = product.Price,
                CurrentImage = product.Image
            };
        }

        public class Response
        {
            public string Name { get; set; }
            public string Category { get; set; }
            public string ShortDescription { get; set; }
            public string Description { get; set; }
            public decimal Price { get; set; }
            public string CurrentImage { get; set; }
        }
    }
}
