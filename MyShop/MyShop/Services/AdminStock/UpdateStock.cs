using MyShop.Domain.Enums;
using MyShop.Domain.Interfaces;
using MyShop.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyShop.Services.AdminStock
{
    [Service]
    public class UpdateStock
    {
        private IProductManager _productManager;
        private IStockManager _stockManager;

        public UpdateStock(IStockManager stockManager, IProductManager productManager)
        {
            _productManager = productManager;
            _stockManager = stockManager;
        }

        public async Task<Response> Do(Request request)
        {
            var stocks = new List<Stock>();

            foreach (var stock in request.Stock)
            {
                if (stocks.Any(x => x.ProductId == stock.ProductId && x.Color == stock.Color && x.Size == stock.Size))
                {
                    stocks.FirstOrDefault(x => x.ProductId == stock.ProductId && x.Color == stock.Color && x.Size == stock.Size).Qty += stock.Qty;
                    await _stockManager.DeleteStock(stock.Id);
                }
                else
                {
                    stocks.Add(new Stock
                    {
                        Id = stock.Id,
                        Qty = stock.Qty,
                        Color = stock.Color,
                        Size = stock.Size,
                        ProductId = stock.ProductId,
                    });
                }
            }

            await _stockManager.UpdateStockRange(stocks);

            var product = _productManager.GetProductWithStock(request.Stock.LastOrDefault().ProductId);

            return new Response
            {
                Id = product.Id,
                ShortDescription = product.ShortDescription,

                Stock = product.Stock.Select(y => new ResponseViewModel
                {
                    Id = y.Id,
                    Size = y.Size,
                    Color = y.Color,
                    Qty = y.Qty,
                })
            };
        }

        public class Request
        {
            public IEnumerable<RequestViewModel> Stock { get; set; }
        }

        public class RequestViewModel
        {
            public int Id { get; set; }
            public int Qty { get; set; }
            public ProductColor Color { get; set; }
            public ProductSize Size { get; set; }
            public int ProductId { get; set; }
        }

        public class Response
        {
            public int Id { get; set; }
            public string ShortDescription { get; set; }
            public IEnumerable<ResponseViewModel> Stock { get; set; }
        }

        public class ResponseViewModel
        {
            public int Id { get; set; }
            public int Qty { get; set; }
            public ProductColor Color { get; set; }
            public ProductSize Size { get; set; }
        }
    }
}
