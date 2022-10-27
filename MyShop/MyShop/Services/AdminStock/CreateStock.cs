using MyShop.Domain.Enums;
using MyShop.Domain.Interfaces;
using MyShop.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Services.AdminStock
{
    [Service]
    public class CreateStock
    {
        private IStockManager _stockManager;
        private IProductManager _productManager;

        public CreateStock(IStockManager stockManager, IProductManager productManager)
        {
            _stockManager = stockManager;
            _productManager = productManager;
        }

        public async Task<Response> Do(Request stockViewModel)
        {
            var stock = new Stock()
            {
                Color = (Domain.Enums.ProductColor)stockViewModel.Color,
                Size = (Domain.Enums.ProductSize)stockViewModel.Size,
                Qty = stockViewModel.Qty,
                ProductId = stockViewModel.ProductId,
            };

            var product = _productManager.GetProductWithStock(stock.ProductId);

            var stocks = product.Stock.Where(x => x.Color == stock.Color && x.Size == stock.Size).FirstOrDefault() ?? null;

            if (stocks != null)
            {
                stocks.Qty += stock.Qty;
                await _stockManager.UpdateStock(stocks);
            } 
            else
                await _stockManager.CreateStock(stock);

            return new Response
            {
                Id = product.Id,
                ShortDescription = product.ShortDescription,

                Stock = product.Stock.Select(y => new StockViewModel
                {
                    Id = y.Id,
                    Qty = y.Qty,
                    Color = y.Color,
                    Size = y.Size
                })
            };
        }

        public class Request
        {
            public int ProductId { get; set; }
            public int Qty { get; set; }
            public int Color { get; set; }
            public int Size { get; set; }
        }

        public class Response
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
