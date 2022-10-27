using MyShop.Domain.Enums;
using MyShop.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace MyShop.Services.AdminStock
{
    [Service]
    public class GetStock
    {
        private IProductManager _productManager;

        public GetStock(IProductManager productManager)
        {
            _productManager = productManager;
        }

        public IEnumerable<ProductViewModel> Do()
        {
            return _productManager.GetProductsWithStock().Select(x => new ProductViewModel
            {
                Id = x.Id,
                ShortDescription = x.ShortDescription,
                Stock = x.Stock.Select(y => new StockViewModel
                {
                    Id = y.Id,
                    Color = y.Color,
                    Size = y.Size,
                    Qty = y.Qty
                }),
            })
            .ToList();
        }

        public class ProductViewModel
        {
            public int Id { get; set; }
            public string ShortDescription { get; set; }
            public IEnumerable<StockViewModel> Stock { get; set; }
        }

        public class StockViewModel
        {
            public int Id { get; set; }
            public int Qty { get; set; }
            public ProductColor Color { get; set; }
            public ProductSize Size { get; set; }

        }
    }
}
